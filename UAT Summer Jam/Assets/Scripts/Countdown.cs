﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    //public int countdownTime;
    public GameObject npcScript;
    public NPCBehavior npcBehavior;

    void Start()
    {
        //StartCoroutine(StartCountdown());
        npcBehavior = npcScript.GetComponent<NPCBehavior>();
        designerChanges = designerScript.GetComponent<DesignerChanges>();
        //countdownTime = designerChanges.guestNeedsInterval;
        InvokeRepeating("GuestNeeds", 0, designerChanges.guestSpawnRate);
        //npcScript = GameObject.Find("NPC");
    }
    void GuestNeeds()
    {
        if (npcBehavior.npcState == 0)
        {
            npcBehavior.RandomState();
            Debug.Log("This is totally working");
        }
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
