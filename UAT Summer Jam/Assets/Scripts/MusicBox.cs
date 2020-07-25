using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicBox : MonoBehaviour
{
    public Button m_RedButton, m_BlueButton, m_GreenButton;
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public GameObject npcScript;
    public NPCBehavior npcBehavior;
    public GameObject playerScript;
    public PlayerInteraction playerInteraction;
    // Start is called before the first frame update
    void Start()
    {
        m_RedButton.onClick.AddListener(RedButtonClick);
        m_BlueButton.onClick.AddListener(BlueButtonClick);
        m_GreenButton.onClick.AddListener(GreenButtonClick);
        playerInteraction = playerScript.GetComponent<PlayerInteraction>();
        npcBehavior = npcScript.GetComponent<NPCBehavior>();
        designerChanges = designerScript.GetComponent<DesignerChanges>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RedButtonClick()
    {
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1 && playerInteraction.triggeringMusic == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.perfectScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.perfectPartyMeterIncrease;
            npcBehavior.whichMusic = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic1 = false;
            // StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2 && playerInteraction.triggeringMusic == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichMusic = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic2 = false;
            // StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3 && playerInteraction.triggeringMusic == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichMusic = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic3 = false;
            // StartCoroutine(cd.StartCountdown());
        }
    }
    void BlueButtonClick()
    {
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2 && playerInteraction.triggeringMusic == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.perfectScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.perfectPartyMeterIncrease;
            npcBehavior.whichMusic = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic2 = false;
            // StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1 && playerInteraction.triggeringMusic == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichMusic = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic1 = false;
            // StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3 && playerInteraction.triggeringMusic == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichMusic = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic3 = false;
            // StartCoroutine(cd.StartCountdown());
        }
    }
    void GreenButtonClick()
    {
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3 && playerInteraction.triggeringMusic == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.perfectScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.perfectPartyMeterIncrease;
            npcBehavior.whichMusic = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic3 = false;
            //StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2 && playerInteraction.triggeringMusic == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichMusic = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic2 = false;
            // StartCoroutine(cd.StartCountdown());
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1 && playerInteraction.triggeringMusic == true)
        {
            playerInteraction.score = playerInteraction.score + designerChanges.okScoreIncrease;
            designerChanges.partyMeter = designerChanges.partyMeter + designerChanges.okPartyMeterIncrease;
            npcBehavior.whichMusic = 0;
            npcBehavior.npcState = 0;
            npcBehavior.needsMusic = false;
            npcBehavior.wantsMusic1 = false;
            // StartCoroutine(cd.StartCountdown());
        }
    }

}
