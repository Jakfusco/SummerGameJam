using Facebook.Unity;
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


    public void RandomState()
    {
        //change to 1-3 for full launch
       npcState =  Random.Range(2,4);
        if (npcState == 1)
        {
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
            needsMusic = true;
            whichMusic = Random.Range(1, 4);
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
        designerChanges = designerScript.GetComponent<DesignerChanges>();
        playerInteraction = playerScript.GetComponent<PlayerInteraction>();
        
    }
    public void PartyMeter()
    {
        if (npcState == 1 || npcState == 2 || npcState == 3)
        {
            
            designerChanges.partyMeter -= designerChanges.partyMeterDecreaseSpeed;
            Debug.Log("Party Decrease");
        }
    }
    public void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);
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
    public void PerfectConversation()
    {
        designerChanges.score += designerChanges.perfectScoreIncrease;
        designerChanges.partyMeter += designerChanges.perfectPartyMeterIncrease;
        whichConvo = 0;
        npcState = 0;
        needsConvo = false;
        wantsConvo3 = false;
        wantsConvo1 = false;
        wantsConvo2 = false;
        Debug.Log("PerfectButtonIsWorking");
    }
    public void OkConversation()
    {
        designerChanges.score += designerChanges.okScoreIncrease;
        designerChanges.partyMeter += designerChanges.okPartyMeterIncrease;
        whichConvo = 0;
        npcState = 0;
        needsConvo = false;
        wantsConvo1 = false;
        wantsConvo3 = false;
        wantsConvo2 = false;
        Debug.Log("OKButtonIsWorking");
    }
    public void PerfectFood()
    {
        designerChanges.score += designerChanges.perfectScoreIncrease;
        designerChanges.partyMeter += designerChanges.perfectPartyMeterIncrease;
        whichFood = 0;
        npcState = 0;
        wantstacos = false;
        needsFood = false;
        wantspizza = false;
        wantswings = false;
    }
    public void OkFood()
    {
        designerChanges.score += designerChanges.okScoreIncrease;
        designerChanges.partyMeter += designerChanges.okPartyMeterIncrease;
        whichFood = 0;
        npcState = 0;
        wantstacos = false;
        needsFood = false;
        wantspizza = false;
        wantswings = false;
    }
}
