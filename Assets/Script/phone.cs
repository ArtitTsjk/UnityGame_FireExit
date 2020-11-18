using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phone : MonoBehaviour, IUseable
{
    public GameObject Phone;
    public static bool OnPhone;
    public GameObject NOOInput;
    public GameObject OTThInput;
    public GameObject OOFZInput;

    private void Start()
    {
        Phone.SetActive(false);
        OnPhone = false;
    }
    public void Use()
    {
        Phone.SetActive(true);
        OnPhone = true;
        PlayerMovement.MoveSound.Stop();
        PlayerMovement.runSpeed = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
                Phone.SetActive(false);
                OnPhone = false;
                PlayerMovement.runSpeed = 40;
                OOFZInput.SetActive(false);
                OTThInput.SetActive(false);
                NOOInput.SetActive(false);
        }
    }

}
