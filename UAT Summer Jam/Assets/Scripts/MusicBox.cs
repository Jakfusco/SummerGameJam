using JetBrains.Annotations;
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
    public GameObject spawningScript;
    public NPCSpawning npcSpawning;

    // Start is called before the first frame update
    void Start()
    {
        m_RedButton.onClick.AddListener(RedButtonClick);
        m_BlueButton.onClick.AddListener(BlueButtonClick);
        m_GreenButton.onClick.AddListener(GreenButtonClick);
        playerInteraction = playerScript.GetComponent<PlayerInteraction>();
        npcBehavior = npcScript.GetComponent<NPCBehavior>();
        npcSpawning = spawningScript.GetComponent<NPCSpawning>();
        designerChanges = designerScript.GetComponent<DesignerChanges>();

        npcSpawning.guest = GameObject.FindGameObjectsWithTag("NPC");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void RedButtonClick()
    {
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1 && playerInteraction.triggeringMusic == true)
        {
            // perfect
            MusicBoxExecutePrePerfect();
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2 && playerInteraction.triggeringMusic == true)
        {
            // ok
            MusicBoxExecutePreOk();
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3 && playerInteraction.triggeringMusic == true)
        {
            // ok
            MusicBoxExecutePreOk();
        }
    }
    void BlueButtonClick()
    {
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2 && playerInteraction.triggeringMusic == true)
        {
            // perfect
            MusicBoxExecutePrePerfect();
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1 && playerInteraction.triggeringMusic == true)
        {
            //ok
            MusicBoxExecutePreOk();
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3 && playerInteraction.triggeringMusic == true)
        {
            // ok
            MusicBoxExecutePreOk();
        }
    }
    void GreenButtonClick()
    {
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3 && playerInteraction.triggeringMusic == true)
        {
            //  perrfect
            MusicBoxExecutePrePerfect();
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2 && playerInteraction.triggeringMusic == true)
        {
            // ok
            MusicBoxExecutePreOk();
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1 && playerInteraction.triggeringMusic == true)
        {
            //  ok
            MusicBoxExecutePreOk();
        }
    }
    public void MusicBoxExecutePrePerfect()
    {
        BroadcastMessage("MusicBoxExecutePerfect", SendMessageOptions.DontRequireReceiver);
        designerChanges.score += designerChanges.perfectScoreIncrease;
        designerChanges.partyMeter += designerChanges.perfectPartyMeterIncrease;
    }
    public void MusicBoxExecutePreOk()
    {
        BroadcastMessage("MusicBoxExecuteOk", SendMessageOptions.DontRequireReceiver);
        designerChanges.score += designerChanges.okScoreIncrease;
        designerChanges.partyMeter += designerChanges.okPartyMeterIncrease;
    }
}
