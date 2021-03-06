﻿
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public GameObject playerScript;
    public PlayerInteraction playerInteraction;
    
    public bool needsFood;
    public int whichFood;
    public bool wantspizza;
    public bool wantswings;
    public bool wantstacos;
    public bool wantsnoFood;
    public bool needsConvo;
    public bool needsMusic;
    public bool needsNothing;
    public int npcState = 0;
    public int whichMusic;
    public bool wantsMusic1;
    public bool wantsMusic2;
    public bool wantsMusic3;
    public int whichConvo;
    public bool wantsConvo1;
    public bool wantsConvo2;
    public bool wantsConvo3;
    public Transform target;
    public bool readyForNeeds;
    // public int partyMeter = 100;
    // public int partyMeterDecrease = 1;
    public Sprite[] popUps;
    public GameObject nPC;
    public GameObject popUpObject;

    public void Awake()
    {
        playerScript = GameObject.Find("Player");
    }
    public void RandomState()
    {
        //change to 1-3 for full launch
       npcState =  Random.Range(1,4);
        if (npcState == 1)
        {
            AudioManager.instance.Play("Annoyed");
            needsFood = true;
            whichFood = Random.Range(1, 4);
            if (whichFood == 1)
            {
                wantspizza = true;
            }
            if (whichFood == 2)
            {
                wantswings = true;
            }
            if (whichFood == 3)
            {
                wantstacos = true;
            }
        }
        if (npcState == 2)
        {
            AudioManager.instance.Play("Annoyed");
            needsConvo = true;
            whichConvo = Random.Range(1, 4);
            if (whichConvo == 1)
            {
                wantsConvo1 = true;
            }
            if (whichConvo == 2)
            {
                wantsConvo2 = true;
            }
            if (whichConvo == 3)
            {
                wantsConvo3 = true;
            }
        }
        if (npcState == 3)
        {
            AudioManager.instance.Play("Annoyed");
            needsMusic = true;
            whichMusic = Random.Range(1, 4);
            MusicBox musicBox = GameObject.Find("Music Box").GetComponent<MusicBox>();
            musicBox.npcScript = this.gameObject;
            musicBox.npcBehavior = this;
            if (whichMusic == 1)
            {
                wantsMusic1 = true;
            }
            if (whichMusic == 2)
            {
                wantsMusic2 = true;
            }
            if (whichMusic == 3)
            {
                wantsMusic3 = true;
            }
        }
       // else
       // {
         //   npcState = 0;
         //   needsNothing = true;
        //}
    }
    private void Start()
    {
        designerScript = GameObject.Find("Designer Changes");
        designerChanges = designerScript.GetComponent<DesignerChanges>();
        playerInteraction = playerScript.GetComponent<PlayerInteraction>();
        InvokeRepeating("PartyMeter", 0, designerChanges.partyMeterDecreaseSpeed);
        target = GameObject.Find("Player").transform;
        
        
    }
    public void PartyMeter()
    {
        if (needsFood || needsConvo || needsMusic)
        {
            
           // partyMeter -= partyMeterDecrease;
            designerChanges.partyMeter -= designerChanges.partyMeterDecreaseRate;
            Debug.Log("Party Decrease");
        }
    }
    public void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
            transform.LookAt(targetPosition);
        }
        if (npcState == 1)
        {

            if (whichFood == 1)
            {

                popUpObject.GetComponent<SpriteRenderer>().sprite = popUps[3];
            }
            if (whichFood == 2)
            {
                popUpObject.GetComponent<SpriteRenderer>().sprite = popUps[5];
            }
            if (whichFood == 3)
            {
                popUpObject.GetComponent<SpriteRenderer>().sprite = popUps[4];
            }
        }

        if (npcState == 2)
        {

            if (whichConvo == 1)
            {
                popUpObject.GetComponent<SpriteRenderer>().sprite = popUps[6];
            }
            if (whichConvo == 2)
            {
                popUpObject.GetComponent<SpriteRenderer>().sprite = popUps[8];
            }
            if (whichConvo == 3)
            {
                popUpObject.GetComponent<SpriteRenderer>().sprite = popUps[7];
            }

        }
        if (npcState == 3)
        {

            if (whichMusic == 1)
            {
                popUpObject.GetComponent<SpriteRenderer>().sprite = popUps[1];
            }
            if (whichMusic == 2)
            {
                popUpObject.GetComponent<SpriteRenderer>().sprite = popUps[0];
            }
            if (whichMusic == 3)
            {
                popUpObject.GetComponent<SpriteRenderer>().sprite = popUps[2];
            }

        }
        if (needsFood == false && needsConvo == false && needsMusic == false)
        {
            popUpObject.GetComponent<SpriteRenderer>().sprite = popUps[10];
        }

    }
    public void MusicBoxExecutePerfect()
    {
        whichMusic = 0;
        npcState = 0;
        needsMusic = false;
        wantsMusic1 = false;
        wantsMusic2 = false;
        wantsMusic3 = false;

    }
    public void MusicBoxExecuteOk()
    {
        whichMusic = 0;
        npcState = 0;
        needsMusic = false;
        wantsMusic1 = false;
        wantsMusic2 = false;
        wantsMusic3 = false;

    }
    //public void PerfectConversation()
    //{
    //    designerChanges.score += designerChanges.perfectScoreIncrease;
    //    designerChanges.partyMeter += designerChanges.perfectPartyMeterIncrease;
    //    whichConvo = 0;
    //    npcState = 0;
    //    needsConvo = false;
    //    wantsConvo3 = false;
    //    wantsConvo1 = false;
    //    wantsConvo2 = false;
    //    Debug.Log("PerfectButtonIsWorking");
    //}
    //public void OkConversation()
    //{
    //    designerChanges.score += designerChanges.okScoreIncrease;
    //    designerChanges.partyMeter += designerChanges.okPartyMeterIncrease;
    //    whichConvo = 0;
    //    npcState = 0;
    //    needsConvo = false;
    //    wantsConvo1 = false;
    //    wantsConvo3 = false;
    //    wantsConvo2 = false;
    //    Debug.Log("OKButtonIsWorking");
    //}
    //public void PerfectFood()
    //{
    //    designerChanges.score += designerChanges.perfectScoreIncrease;
    //    designerChanges.partyMeter += designerChanges.perfectPartyMeterIncrease;
    //    whichFood = 0;
    //    npcState = 0;
    //    wantstacos = false;
    //    needsFood = false;
    //    wantspizza = false;
    //    wantswings = false;
    //    Debug.Log("PerfectButtonIsWorking");
    //}
    //public void OkFood()
    //{
    //    designerChanges.score += designerChanges.okScoreIncrease;
    //    designerChanges.partyMeter += designerChanges.okPartyMeterIncrease;
    //    whichFood = 0;
    //    npcState = 0;
    //    wantstacos = false;
    //    needsFood = false;
    //    wantspizza = false;
    //    wantswings = false;
    //    Debug.Log("OKButtonIsWorking");
    //}
}
