using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCon : MonoBehaviour
{
    public Animator animator;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;      
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }
}
