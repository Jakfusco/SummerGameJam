using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public GameObject npcScript;
    public NPCBehavior npcBehavior;
    public GameObject playerScript;
    public PlayerInteraction playerInteraction;
    public GameObject cdScript;
    public Countdown cd;
    public Button m_RedButton, m_BlueButton, m_GreenButton;
    public GameObject nPC;
    public Sprite[] partyGuests;
    public GameObject[] guests;
    public int guestRandomizer;

    private void Start()
    {
        playerInteraction = playerScript.GetComponent<PlayerInteraction>();
        npcBehavior = npcScript.GetComponent<NPCBehavior>();
        cd = cdScript.GetComponent<Countdown>();
        designerChanges = designerScript.GetComponent<DesignerChanges>();
        
        InvokeRepeating("NPCSpawn", 0, designerChanges.guestSpawnRate);
        
            m_RedButton.onClick.AddListener(RedButtonClick);
            m_BlueButton.onClick.AddListener(BlueButtonClick);
        m_GreenButton.onClick.AddListener(GreenButtonClick);
    }
    
    

    void RedButtonClick()
    {
        //Debug.Log("you have clicked red");
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 1 && playerInteraction.haspizza == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.perfectScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.perfectPartyMeterIncrease;
            npcBehavior.whichFood = 0; 
            npcBehavior.npcState = 0;
            npcBehavior.wantspizza = false;
            npcBehavior.needsFood = false;
            //StartCoroutine(cd.StartCountdown());
            playerInteraction.haspizza = false;
        }
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 2 && playerInteraction.haswings == true || npcBehavior.npcState == 1 && npcBehavior.whichFood == 3 && playerInteraction.hastacos == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichFood = 0;
            npcBehavior.npcState = 0;
            npcBehavior.wantspizza = false;
            npcBehavior.needsFood = false;
            // StartCoroutine(cd.StartCountdown());
            playerInteraction.haspizza = false;
        }
        
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo1 == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.perfectScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.perfectPartyMeterIncrease;
            npcBehavior.whichConvo = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo1 = false;
            //StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo2 == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichConvo = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo2 = false;
          //  StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo3 == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichConvo = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo3 = false;
           // StartCoroutine(cd.StartCountdown());
        }
        
    }
    void BlueButtonClick()
    {
        //Debug.Log("you have clicked blue");
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 2 && playerInteraction.haswings == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.perfectScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.perfectPartyMeterIncrease;
            npcBehavior.whichFood = 0;
            npcBehavior.npcState = 0;
            npcBehavior.wantswings = false;
            npcBehavior.needsFood = false;
            //StartCoroutine(cd.StartCountdown());
            playerInteraction.haswings = false;
        }
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 1 && playerInteraction.haspizza == true || npcBehavior.npcState == 1 && npcBehavior.whichFood == 3 && playerInteraction.hastacos == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichFood = 0;
            npcBehavior.npcState = 0;
            npcBehavior.wantswings = false;
            npcBehavior.needsFood = false;
            //  StartCoroutine(cd.StartCountdown());
            playerInteraction.haswings = false;
        }
        
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo1 == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichConvo = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo1 = false;
           // StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo2 == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.perfectScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.perfectPartyMeterIncrease;
            npcBehavior.whichConvo = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo2 = false;
           // StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo3 == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichConvo = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo3 = false;
          //  StartCoroutine(cd.StartCountdown());
        }
       
    }
    void GreenButtonClick()
    {
        //Debug.Log("you have clicked green");
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 3 && playerInteraction.hastacos == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.perfectScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.perfectPartyMeterIncrease;
            npcBehavior.whichFood = 0;
            npcBehavior.npcState = 0;
            npcBehavior.wantstacos = false;
            npcBehavior.needsFood = false;
            //StartCoroutine(cd.StartCountdown());
            playerInteraction.hastacos = false;
        }
        if (npcBehavior.npcState == 1 && npcBehavior.whichFood == 2 && playerInteraction.haswings == true || npcBehavior.npcState == 1 && npcBehavior.whichFood == 1 && playerInteraction.haspizza == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichFood = 0;
            npcBehavior.npcState = 0;
            npcBehavior.wantstacos = false;
            npcBehavior.needsFood = false;
            // StartCoroutine(cd.StartCountdown());
            playerInteraction.hastacos = false;
        }
        
        if(npcBehavior.npcState == 2 && npcBehavior.wantsConvo1 == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichConvo = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo1 = false;
           // StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo2 == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichConvo = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo2 = false;
            //StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 2 && npcBehavior.wantsConvo3 == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.perfectScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.perfectPartyMeterIncrease;
            npcBehavior.whichConvo = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsConvo = false;
            npcBehavior.wantsConvo3 = false;
           // StartCoroutine(cd.StartCountdown());
        }
        
    }
    public void NPCSpawn()
    {

        GameObject Clone;
        Clone = (Instantiate(nPC)) as GameObject;
        
        int i = Random.Range(0, partyGuests.Length);
        Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[i];

    }
}
