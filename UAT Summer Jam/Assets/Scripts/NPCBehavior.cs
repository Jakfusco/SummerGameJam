//using Facebook.Unity;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
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
       npcState =  Random.Range(1, 4);
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
        //InvokeRepeating("PartyMeter", 0, designerChanges.partyMeterDecreaseRate);
        designerChanges = designerScript.GetComponent<DesignerChanges>();
    }
    public void PartyMeter()
    {
        if (npcState == 1 || npcState == 2 || npcState == 3)
        {
            
            designerChanges.partyMeter -= designerChanges.partyMeterDecreaseSpeed;
            Debug.Log("Party Decrease");
        }
    }
    private void Update()
    {
          //  Vector3 lookVector = player.transform.position - transform.position;
            //lookVector.y = transform.position.y;
           // Quaternion rot = Quaternion.LookRotation(lookVector);
            //transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1);
        if (target != null)
        {
            transform.LookAt(target);
        }
    }

}
