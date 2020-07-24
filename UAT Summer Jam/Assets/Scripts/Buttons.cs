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
            AudioManager.instance.Play("FoodDelivered");
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
            AudioManager.instance.Play("FoodDelivered");
        }
        if (playerInteraction.triggeringTable == true)
        {
            AudioManager.instance.Play("Pickup");
            npcBehavior.haspizza = true;
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo1 == true)
        {
            playerInteraction.score = playerInteraction.score + 25;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo1 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Click");
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo2 == true)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo2 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Click");
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo3 == true)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo3 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Click");
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1)
        {
            playerInteraction.score = playerInteraction.score + 25;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic1 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Techno");
            AudioManager.instance.Stop("Rock");
            AudioManager.instance.Stop("HipHop");
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic2 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Techno");
            AudioManager.instance.Stop("Rock");
            AudioManager.instance.Stop("HipHop");
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic3 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Techno");
            AudioManager.instance.Stop("Rock");
            AudioManager.instance.Stop("HipHop");
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
            AudioManager.instance.Play("FoodDelivered");
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
            AudioManager.instance.Play("FoodDelivered");
        }
        if (playerInteraction.triggeringTable == true)
        {
            npcBehavior.haswings = true;
            AudioManager.instance.Play("Pickup");
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo1 == true)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo1 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Click");
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo2 == true)
        {
            playerInteraction.score = playerInteraction.score + 25;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo2 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Click");
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo3 == true)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo3 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Click");
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2)
        {
            playerInteraction.score = playerInteraction.score + 25;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic2 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Play("Rock");
            AudioManager.instance.Stop("HipHop");
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic1 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Play("Rock");
            AudioManager.instance.Stop("HipHop");
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic3 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Play("Rock");
            AudioManager.instance.Stop("HipHop");
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
            AudioManager.instance.Play("FoodDelivered");
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
            AudioManager.instance.Play("FoodDelivered");
        }
        if (playerInteraction.triggeringTable == true)
        {
            npcBehavior.hastacos = true;
            AudioManager.instance.Play("Pickup");
        }
        if(npcBehavior.npcState == 2 && npcBehavior.wantsConvo1 == true)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo1 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Click");
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo2 == true)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo2 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Click");
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo3 == true)
        {
            playerInteraction.score = playerInteraction.score + 25;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo3 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Play("Click");
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3)
        {
            playerInteraction.score = playerInteraction.score + 25;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic3 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Stop("Rock");
            AudioManager.instance.Play("HipHop");
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic2 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Stop("Rock");
            AudioManager.instance.Play("HipHop");
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1)
        {
            playerInteraction.score = playerInteraction.score + 10;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic1 = false;
            StartCoroutine(cd.StartCountdown());
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Stop("Rock");
            AudioManager.instance.Play("HipHop");
        }
    } 
}
