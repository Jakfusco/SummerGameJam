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
    public GameObject buttonParent;
    public bool playerTrigger;
    // public Sprite[] partyGuests;
    // public GameObject[] guests;
    // public int guestRandomizer;

    private void Awake()
    {
        m_RedButton = GameObject.Find("RedOption").GetComponent<Button>();
        m_BlueButton = GameObject.Find("BlueOption").GetComponent<Button>();
        m_GreenButton = GameObject.Find("GreenOption").GetComponent<Button>();
        buttonParent = GameObject.Find("NPC Food Buttons");
        playerScript = GameObject.Find("Player");
       // npcScript = GameObject.Find("NPC");
    }
    private void Start()
    {

        playerInteraction = playerScript.GetComponent<PlayerInteraction>();
        npcBehavior = npcScript.GetComponent<NPCBehavior>();
        cd = cdScript.GetComponent<Countdown>();
        designerChanges = designerScript.GetComponent<DesignerChanges>();


        // InvokeRepeating("NPCSpawn", 0, designerChanges.guestSpawnRate);

        m_RedButton.onClick.AddListener(RedButtonClick);
        m_BlueButton.onClick.AddListener(BlueButtonClick);
        m_GreenButton.onClick.AddListener(GreenButtonClick);
        //buttonParent.SetActive(false);
    }
    
    

    public void RedButtonClick()
    {
        //Debug.Log("you have clicked red");
        if (npcBehavior.needsFood && npcBehavior.wantspizza && playerInteraction.haspizza == true && playerTrigger)
        {
            PerfectFood();
        }
        if (npcBehavior.needsFood && npcBehavior.wantswings && playerInteraction.haswings == true && playerTrigger || npcBehavior.needsFood && npcBehavior.wantstacos && playerInteraction.hastacos == true && playerTrigger)
        {
            OkFood();
        }

        if (npcBehavior.wantsConvo1 == true && playerInteraction.triggering)
        {
            PerfectConversation();
        }
        if (npcBehavior.wantsConvo2 == true && playerInteraction.triggering)
        {
            OkConversation();
        }
        if (npcBehavior.wantsConvo3 == true && playerInteraction.triggering)
        {
            OkConversation();
        }

    }
    public void BlueButtonClick()
    {
        //Debug.Log("you have clicked blue");
        if (npcBehavior.needsFood && npcBehavior.wantswings && playerInteraction.haswings == true && playerTrigger)
        {
            PerfectFood();
        }
        if (npcBehavior.needsFood && npcBehavior.wantspizza && playerInteraction.haspizza == true && playerTrigger || npcBehavior.needsFood && npcBehavior.wantstacos && playerInteraction.hastacos == true && playerTrigger)
        {
            OkFood();
        }

        if (npcBehavior.wantsConvo1 == true)
        {
            OkConversation();
        }
        if (npcBehavior.wantsConvo2 == true)
        {
            PerfectConversation();
        }
        if (npcBehavior.wantsConvo3 == true)
        {
            OkConversation();
        }

    }
    public void GreenButtonClick()
    {
        //Debug.Log("you have clicked green");
        if (npcBehavior.needsFood && npcBehavior.wantstacos && playerInteraction.hastacos == true && playerTrigger)
        {
            PerfectFood();
        }
        if (npcBehavior.needsFood && npcBehavior.wantswings && playerInteraction.haswings == true && playerTrigger || npcBehavior.needsFood && npcBehavior.wantspizza && playerInteraction.haspizza == true && playerTrigger)
        {
            OkFood();
        }

        if (npcBehavior.wantsConvo1)
        {
            OkConversation();
        }
        if (npcBehavior.wantsConvo2)
        {
            OkConversation();
        }
        if (npcBehavior.wantsConvo3)
        {

            PerfectConversation();
        }

    }
    //  public void NPCSpawn()
    //  {

    //   GameObject Clone;
    //   Clone = (Instantiate(nPC)) as GameObject;

    //  int i = Random.Range(0, partyGuests.Length);
    //  Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[i];

    // }
    public void PerfectConversation()
    {
        designerChanges.score += designerChanges.perfectScoreIncrease;
        designerChanges.partyMeter += designerChanges.perfectPartyMeterIncrease;
        npcBehavior.whichConvo = 0;
        npcBehavior.npcState = 0;
        npcBehavior.needsConvo = false;
        npcBehavior.wantsConvo3 = false;
        npcBehavior.wantsConvo1 = false;
        npcBehavior.wantsConvo2 = false;
        Debug.Log("PerfectButtonIsWorking");
    }
    public void OkConversation()
    {
        designerChanges.score += designerChanges.okScoreIncrease;
        designerChanges.partyMeter += designerChanges.okPartyMeterIncrease;
        npcBehavior.whichConvo = 0;
        npcBehavior.npcState = 0;
        npcBehavior.needsConvo = false;
        npcBehavior.wantsConvo1 = false;
        npcBehavior.wantsConvo3 = false;
        npcBehavior.wantsConvo2 = false;
        Debug.Log("OKButtonIsWorking");
    }
    public void PerfectFood()
    {
        designerChanges.score += designerChanges.perfectScoreIncrease;
        designerChanges.partyMeter += designerChanges.perfectPartyMeterIncrease;
        npcBehavior.whichFood = 0;
        npcBehavior.npcState = 0;
        npcBehavior.wantstacos = false;
        npcBehavior.needsFood = false;
        npcBehavior.wantspizza = false;
        npcBehavior.wantswings = false;
        Debug.Log("PerfectButtonIsWorking");
    }
    public void OkFood()
    {
        designerChanges.score += designerChanges.okScoreIncrease;
        designerChanges.partyMeter += designerChanges.okPartyMeterIncrease;
        npcBehavior.whichFood = 0;
        npcBehavior.npcState = 0;
        npcBehavior.wantstacos = false;
        npcBehavior.needsFood = false;
        npcBehavior.wantspizza = false;
        npcBehavior.wantswings = false;
        Debug.Log("OKButtonIsWorking");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTrigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTrigger = false;
        }
    }
}
