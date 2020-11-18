using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
   
    [SerializeField] Transform spawnPoint;
    public Rigidbody2D rb;
    public CharacterController2D controller;
    public Animator animator;
    public float SmokeTotalTime = 0f;
    private IUseable useable;
    public static int life = 3;
    public static int hitpoint = 4;
    public static bool IsMoving;
    public static AudioSource MoveSound;
    public static float runSpeed = 40f;
    [SerializeField]
    private float climbSpeed;

    float horizontalMove = 0f;
    float verticalMove = 0f;
    bool jump = false;
    public bool crouch  { get; set; }
    bool isHurting, isDead;
    float dirX = 5f;
    bool facingRight = true;
    bool IsClimb ;
    Vector3 localScale;
    public bool OnLadder { get; set; }
    public static PlayerMovement instance = null;
    int sceneIndex, levelPassed;

    int playerLayer, platformLayer;
    bool jumpOffCoroutineIsRunning = false;

    public static PlayerMovement Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<PlayerMovement>();
            }
            return instance;
        }
    }

    void Start()
    {
        Debug.Log("levelpass" + levelPassed);
        Debug.Log("life" + life);
        Debug.Log("sceneIndex" + sceneIndex);
        playerLayer = LayerMask.NameToLayer("Player");
        platformLayer = LayerMask.NameToLayer("Platform");

        animator = GetComponent<Animator>();
        
        life = 3;
        
        hitpoint = 4;
        
        MoveSound = GetComponent<AudioSource>();
        
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 4;
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");

    }


    // Update is called once per frame
    void Update()
    {
       
        if (OnLadder && !Guide1.OnGuide && !Guide.OnGuide)
        {
            verticalMove = Input.GetAxisRaw("Vertical") * climbSpeed;
            animator.speed = verticalMove != 0 ? Mathf.Abs(verticalMove) : Mathf.Abs(horizontalMove);
            rb.velocity = new Vector2(horizontalMove * climbSpeed, verticalMove * climbSpeed);

        }
        else if (!Guide1.OnGuide && !Guide.OnGuide)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
            if (Input.GetButton("Horizontal"))
            {
                IsMoving = true;
            }
            else if (Input.GetButtonUp("Horizontal"))
            {
                IsMoving = false;
            }

            if (IsMoving == true && !crouch && !phone.OnPhone && !Pause.GameIsPause)
            {
                if (!MoveSound.isPlaying)
                    MoveSound.Play();
            }
            else
            {
                    MoveSound.Stop(); 
            }

            if (Input.GetButtonDown("Jump") && !OnLadder && !phone.OnPhone)
            {
                jump = true;
                animator.SetBool("IsJumping", true);
                SoundManager.PlaySound("jump");
            }


            if (Input.GetButtonDown("Crouch") && !OnLadder && !phone.OnPhone)
            {
                crouch = true;

            }
            else if (Input.GetButtonUp("Crouch"))
            {
                crouch = false;
            }
        }
        HandleInput();
        
    }

    void FixedUpdate()
    {
        // Move our character
        
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump, IsClimb);

        jump = false;
        if (!isDead)
            dirX = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (isDead == true)
        {
            runSpeed = 0;
        }
        if (life <= 0)
        {
            isDead = true;
            animator.SetBool("IsDead", true); 
            MoveSound.Stop();
            isHurting = false;
        }


    }
    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.E) && !OnLadder)
        {
            Use();
        }
    }
    private void Use()
    {
        if (useable != null)
        {
            useable.Use();
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ladder")
        {
            useable = other.GetComponent<IUseable>();
        }

    }
    public void youWin()
    {
        if (sceneIndex == 11)
            Invoke("loadMainMenu", 1f);
        else
        {
            if (levelPassed < sceneIndex)
                PlayerPrefs.SetInt("LevelPassed", sceneIndex);

            //Invoke("loadNextLevel", 1f);
        }
    }
    void loadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    void loadMainMenu()
    {
        SceneManager.LoadScene("Openning");
    }


    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }


    void OnCollisionEnter2D(Collision2D player)
    {
        if (player.gameObject.tag == "fire")
        {
            hitpoint--;
            animator.SetTrigger("IsHurting");
            StartCoroutine("Hurt");
            SoundManager.PlaySound("FireHit");
            if (hitpoint <= 0)
            {
                life--;
                transform.position = spawnPoint.position;
                hitpoint = 4;
            }
        }
        if (player.gameObject.tag == "deadfloor")
        {
            hitpoint -= 4;
            SoundManager.PlaySound("FireHit");
            if (hitpoint <= 0)
            {
                life--;
                transform.position = spawnPoint.position;
                hitpoint = 4;
            }
        }
    }

    void OnTriggerStay2D(Collider2D player)
    {

        if (player.gameObject.tag == "smoke")
        {
            SmokeTotalTime += Time.deltaTime;

            if (SmokeTotalTime > 1)
            {
                hitpoint--;
                SoundManager.PlaySound("FireHit");
                SmokeTotalTime = 0.5f;
                Debug.Log("time" + SmokeTotalTime);
            }

            if (hitpoint <= 0)
            {
                life--;
                transform.position = spawnPoint.position;
                hitpoint = 4;
            }
        }
    }


    void CheckWhereToFace()
    {
        if (dirX > 0)
            facingRight = true;
        else if (dirX < 0)
            facingRight = false;

        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;

        transform.localScale = localScale;

    }

    IEnumerator Hurt()
    {
        isHurting = true;
        rb.velocity = Vector2.zero;

        if (facingRight)
            rb.AddForce(new Vector2(-1500, 100));
        else
            rb.AddForce(new Vector2(1500, 100));

        yield return new WaitForSeconds(0.5f);

        isHurting = false;
    }
    IEnumerator JumpOff()
    {
        jumpOffCoroutineIsRunning = true;
        Physics2D.IgnoreLayerCollision(playerLayer, platformLayer, true);
        
        yield return new WaitForSeconds(1f);
        Physics2D.IgnoreLayerCollision(playerLayer, platformLayer, false);
        jumpOffCoroutineIsRunning = false;
        
    }
}
