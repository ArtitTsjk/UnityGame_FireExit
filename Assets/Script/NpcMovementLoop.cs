using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovementLoop : MonoBehaviour {

    public bool movingRight = true;
    public Animator animator;

    [SerializeField]
	Transform[] waypoints;

	[SerializeField]
	float moveSpeed = 2f;
	int waypointIndex = 0;

	void Start () {
		transform.position = waypoints [waypointIndex].transform.position;
        movingRight = true;
        animator = GetComponent<Animator>();
    }

	void Update () {
		Move ();
        animator.SetFloat("Speed", Mathf.Abs(moveSpeed));
        if (movingRight == true)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (movingRight == false)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
    }

	void Move()
	{      
        transform.position = Vector2.MoveTowards (transform.position,
												waypoints[waypointIndex].transform.position,
                                                moveSpeed * Time.deltaTime);
		if (transform.position == waypoints [waypointIndex].transform.position) {
			waypointIndex += 1;
        }
				
		if (waypointIndex == waypoints.Length)
			waypointIndex = 0;
        if (waypointIndex == 0)
        {
            movingRight = false;
        }
        else if (waypointIndex != 0)
        {
            movingRight = true;
        }
    }

}
