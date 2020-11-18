using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emegency : MonoBehaviour, IUseable
{
    public KeyCode Close;
    public GameObject alarmbell, Otheralarmbell1, Otheralarmbell2, Otheralarmbell3, Otheralarmbell4;
    public GameObject NPC1, NPC2;
    public GameObject CloseDoor, Exit;

    // Start is called before the first frame update
    void Start()
    {
        NPC1.SetActive(false);
        NPC2.SetActive(false);
        Exit.SetActive(false);
    }

    public void Use()
    {        
        SoundManager.PlaySound("alarmbell");
        NPC1.SetActive(true);
        NPC2.SetActive(true);
        Exit.SetActive(true);
        Destroy(alarmbell);
        Destroy(Otheralarmbell1);
        Destroy(Otheralarmbell2);
        Destroy(Otheralarmbell3);
        Destroy(Otheralarmbell4);
        Destroy(CloseDoor);
    }

}
