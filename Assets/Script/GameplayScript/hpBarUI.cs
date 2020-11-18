using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpBarUI : MonoBehaviour
{
    public Sprite[] HpBar;
    public Image HpUI;
    private PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        HpUI.sprite = HpBar[PlayerMovement.hitpoint];
    }
}
