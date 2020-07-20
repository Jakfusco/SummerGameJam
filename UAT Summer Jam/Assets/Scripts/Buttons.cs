using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject npcScript;
    public NPCBehavior npcBehavior;
    public GameObject playerScript;
    public PlayerInteraction playerInteraction;
    public GameObject cdScript;
    // public int[] foodStuffs;
    public Countdown cd;
    public Button m_RedButton, m_BlueButton, m_GreenButton;

    private void Start()
    {
        playerInteraction = playerScript.GetComponent<PlayerInteraction>();
        npcBehavior = npcScript.GetComponent<NPCBehavior>();
        cd = cdScript.GetComponent<Countdown>();
        m_RedButton.onClick.AddListener(RedButtonClick);
        m_BlueButton.onClick.AddListener(BlueButtonClick);
        m_GreenButton.onClick.AddListener(GreenButtonClick);
    }
    
    

    void RedButtonClick()
    {
        //Debug.Log("you have clicked red");
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 1 && npcBehavior.haspizza == true)
        {
            playerInteraction.score = playerInteraction.score + 25;
            npcBehavior.whichFood = 0; 
            npcBehavior.npcState = 0;
            npcBehavior.wantspizza = false;
            npcBehavior.needsFood = false;
            StartCoroutine(cd.StartCountdown());
            npcBehavior.haspizza = false;
        }
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 2 && npcBehavior.haswings == true || npcBehavior.npcState == 1 && npcBehavior.whichFood == 3 && npcBehavior.hastacos == true)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.whichFood = 0;
            npcBehavior.npcState = 0;
            npcBehavior.wantspizza = false;
            npcBehavior.needsFood = false;
            StartCoroutine(cd.StartCountdown());
            npcBehavior.haspizza = false;
        }
        if (playerInteraction.triggeringTable == true)
        {
            npcBehavior.haspizza = true;
        }

    }
    void BlueButtonClick()
    {
        //Debug.Log("you have clicked blue");
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 2 && npcBehavior.haswings == true)
        {
            playerInteraction.score = playerInteraction.score + 25;
            npcBehavior.whichFood = 0;
            npcBehavior.npcState = 0;
            npcBehavior.wantswings = false;
            npcBehavior.needsFood = false;
            StartCoroutine(cd.StartCountdown());
            npcBehavior.haswings = false;
        }
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 1 && npcBehavior.haspizza == true || npcBehavior.npcState == 1 && npcBehavior.whichFood == 3 && npcBehavior.hastacos == true)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.whichFood = 0;
            npcBehavior.npcState = 0;
            npcBehavior.wantswings = false;
            npcBehavior.needsFood = false;
            StartCoroutine(cd.StartCountdown());
            npcBehavior.haswings = false;
        }
        if (playerInteraction.triggeringTable == true)
        {
            npcBehavior.haswings = true;
        }
    }
    void GreenButtonClick()
    {
        //Debug.Log("you have clicked green");
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 3 && npcBehavior.hastacos == true)
        {
            playerInteraction.score = playerInteraction.score + 25;
            npcBehavior.whichFood = 0;
            npcBehavior.npcState = 0;
            npcBehavior.wantstacos = false;
            npcBehavior.needsFood = false;
            StartCoroutine(cd.StartCountdown());
            npcBehavior.hastacos = false;
        }
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 2 && npcBehavior.haswings == true || npcBehavior.npcState == 1 && npcBehavior.whichFood == 1 && npcBehavior.haspizza == true)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.whichFood = 0;
            npcBehavior.npcState = 0;
            npcBehavior.wantstacos = false;
            npcBehavior.needsFood = false;
            StartCoroutine(cd.StartCountdown());
            npcBehavior.hastacos = false;
        }
        if (playerInteraction.triggeringTable == true)
        {
            npcBehavior.hastacos = true;
        }
    } 
}
