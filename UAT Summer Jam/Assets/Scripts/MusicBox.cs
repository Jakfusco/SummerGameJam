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

        if (npcBehavior != null)
        {
            npcBehavior = npcScript.GetComponent<NPCBehavior>();
        }
        npcSpawning = spawningScript.GetComponent<NPCSpawning>();
        designerChanges = designerScript.GetComponent<DesignerChanges>();
        //npcScript = GameObject.Find("NPC");
        npcSpawning.guest = GameObject.FindGameObjectsWithTag("NPC");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void RedButtonClick()
    {
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1 && playerInteraction.triggeringMusic == true && npcBehavior != null && npcScript != null)
        {
            // perfect
            MusicBoxExecutePrePerfect();
            AudioManager.instance.Play("HipHop");
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Stop("Rock");
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2 && playerInteraction.triggeringMusic == true && npcBehavior != null && npcScript != null)
        {
            // ok
            MusicBoxExecutePreOk();
            AudioManager.instance.Play("HipHop");
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Stop("Rock");
        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3 && playerInteraction.triggeringMusic == true && npcBehavior != null && npcScript != null)
        {
            // ok
            MusicBoxExecutePreOk();
            AudioManager.instance.Play("HipHop");
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Stop("Rock");

        }
    }
    void BlueButtonClick()
    {
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2 && playerInteraction.triggeringMusic == true && npcBehavior != null && npcScript != null)
        {
            // perfect
            MusicBoxExecutePrePerfect();
            AudioManager.instance.Stop("HipHop");
            AudioManager.instance.Play("Techno");
            AudioManager.instance.Stop("Rock");

        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1 && playerInteraction.triggeringMusic == true && npcBehavior != null && npcScript != null)
        {
            //ok
            MusicBoxExecutePreOk();
            AudioManager.instance.Stop("HipHop");
            AudioManager.instance.Play("Techno");
            AudioManager.instance.Stop("Rock");

        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3 && playerInteraction.triggeringMusic == true && npcBehavior != null && npcScript != null)
        {
            // ok
            MusicBoxExecutePreOk();
            AudioManager.instance.Stop("HipHop");
            AudioManager.instance.Play("Techno");
            AudioManager.instance.Stop("Rock");

        }
    }
    void GreenButtonClick()
    {
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic3 && playerInteraction.triggeringMusic == true && npcBehavior != null && npcScript != null)
        {
            //  perrfect
            MusicBoxExecutePrePerfect();
            AudioManager.instance.Stop("HipHop");
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Play("Rock");

        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic2 && playerInteraction.triggeringMusic == true && npcBehavior != null && npcScript != null)
        {
            // ok
            MusicBoxExecutePreOk();
            AudioManager.instance.Stop("HipHop");
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Play("Rock");

        }
        if (npcBehavior.npcState == 3 && npcBehavior.wantsMusic1 && playerInteraction.triggeringMusic == true && npcBehavior != null && npcScript != null)
        {
            //  ok
            MusicBoxExecutePreOk();
            AudioManager.instance.Stop("HipHop");
            AudioManager.instance.Stop("Techno");
            AudioManager.instance.Play("Rock");

        }
    }
    public void MusicBoxExecutePrePerfect()
    {
        BroadcastMessage("MusicBoxExecutePerfect", SendMessageOptions.DontRequireReceiver);
        foreach (NPCBehavior npcBehavior in FindObjectsOfType<NPCBehavior>())
        {
            npcBehavior.MusicBoxExecutePerfect();
        }
        designerChanges.score += designerChanges.perfectScoreIncrease;
        designerChanges.partyMeter += designerChanges.perfectPartyMeterIncrease;
    }
    public void MusicBoxExecutePreOk()
    {
        foreach (NPCBehavior npcBehavior in FindObjectsOfType<NPCBehavior>())
        {
            npcBehavior.MusicBoxExecuteOk();
        }
        BroadcastMessage("MusicBoxExecuteOk", SendMessageOptions.DontRequireReceiver);
        designerChanges.score += designerChanges.okScoreIncrease;
        designerChanges.partyMeter += designerChanges.okPartyMeterIncrease;
    }
    //void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "NPC")
    //    {
    //        npcScript = null;
    //        npcBehavior = null;
    //    }
    //}
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "NPC")
    //    {
    //        npcBehavior = other.gameObject.GetComponent<NPCBehavior>();
    //        npcScript = other.gameObject;
    //    }
    //}
    }
