using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource[] allAudioSources;
    public static AudioClip playerFireHitSound, playerHomeHitSound, jumpSound, walkSound, FireSound, btnOP, btnMENU, btn3, alarmbell;
    public static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        playerFireHitSound = Resources.Load<AudioClip>("ชนไฟ");
        playerHomeHitSound = Resources.Load<AudioClip>("ชนบ้าน");
        jumpSound = Resources.Load<AudioClip>("โดด");
        walkSound = Resources.Load<AudioClip>("เดิน2");
        FireSound = Resources.Load<AudioClip>("ไฟไหม้");
        btnOP = Resources.Load<AudioClip>("button");
        btnMENU = Resources.Load<AudioClip>("button2");
        btn3 = Resources.Load<AudioClip>("button3");
        alarmbell = Resources.Load<AudioClip>("เสียงกริ่ง");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "FireHit":
                audioSrc.PlayOneShot(playerFireHitSound);
                break;
            case "HomeHit":
                audioSrc.PlayOneShot(playerHomeHitSound);
                break;
            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "Fire":
                audioSrc.PlayOneShot(FireSound);
                break;
            case "walk":
                audioSrc.PlayOneShot(walkSound);
                break;
            case "btnOP":
                audioSrc.PlayOneShot(btnOP);
                break;
            case "btnMENU":
                audioSrc.PlayOneShot(btnMENU);
                break;
            case "btn3":
                audioSrc.PlayOneShot(btn3);
                break;
            case "alarmbell":
                audioSrc.PlayOneShot(alarmbell);
                break;

        }

    }

}
