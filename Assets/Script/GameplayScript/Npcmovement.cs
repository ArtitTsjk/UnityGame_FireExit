using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npcmovement : MonoBehaviour
{
    public Animator animator;
    [SerializeField]
    Transform[] waypoints;

    [SerializeField]
    float moveSpeed = 4f;

    int waypointIndex = 0;

    bool move = false;
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
        move = false;

    }

    void Update()
    {
        if (move == true)
        {

            transform.position = Vector2.MoveTowards(transform.position,
                                                    waypoints[waypointIndex].transform.position,
                                                    moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }

            if (waypointIndex == waypoints.Length)
                waypointIndex = 0;
            animator.SetBool("IsMove", true);
        }
    }

    public void OnTriggerStay2D(Collider2D other)
    { 
        if (other.tag == "Player")
        {
            move = true;
        }
    }


      

}
