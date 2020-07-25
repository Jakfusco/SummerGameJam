using System.Collections;
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
    }
    //public IEnumerator StartCountdown()
   // {
     //  while (designerChanges.guestNeedsInterval > 0)
     //  {
     //       yield return new WaitForSeconds(1f);
       //     designerChanges.guestNeedsInterval--;
       //     Debug.Log("" + designerChanges.guestNeedsInterval);
     // }
     //  npcBehavior.RandomState();
     //   Debug.Log("Timer is working");
     //  designerChanges.guestNeedsInterval = designerChanges.guestNeedsReset;
    //}
    //private void Update()
   //{
       // if (npcBehavior.needsConvo && npcBehavior.needsFood && npcBehavior.needsMusic && designerChanges.guestNeedsInterval == 0)
      //  {
            //StartCoroutine(StartCountdown());

        //}
       // else
       // {
            
       // }
  //  }
    void GuestNeeds()
    {
        if (npcBehavior.npcState == 0)
        {
            npcBehavior.RandomState();
            Debug.Log("This is totally working");
        }
    }

}
