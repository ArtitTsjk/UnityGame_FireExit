using UnityEngine;
using System.Collections;

public class StairControl2 : MonoBehaviour {

		public GameObject realstair;
        public GameObject Otherstair;
        public GameObject floortarget;
        public GameObject Otherstair2;
    // Use this for initialization
    void Start () {
		realstair.SetActive(true);
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}


		public void OnTriggerStay2D (Collider2D other)
		{
			if (other.tag == "Player"){
				 	if (Input.GetKey (KeyCode.UpArrow) && Input.GetButton ("Horizontal"))	
				 	{
					 	realstair.SetActive(true);
                        Otherstair.SetActive(false);
                        floortarget.SetActive(false);
                    }
					
					else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetButtonUp("Horizontal"))
					{
						realstair.SetActive(false);                       
                    }
			}	
				
		}
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            floortarget.SetActive(true);
            Otherstair2.SetActive(true);
        }
    }
}

