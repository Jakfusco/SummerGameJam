using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    public int countdownTime;
    public GameObject npcScript;
    public NPCBehavior npcBehavior;
    void Start()
    {
        StartCoroutine(StartCountdown());
        npcBehavior = npcScript.GetComponent<NPCBehavior>();
    }
    public IEnumerator StartCountdown()
    {
        while (countdownTime > 0)
        {
            yield return new WaitForSeconds(1f);
            countdownTime--;
            Debug.Log("" + countdownTime);
        }
        npcBehavior.RandomState();
        Debug.Log("Timer is working");
        countdownTime = 10;
    }
    private void Update()
    {
        if (npcBehavior.needsConvo == false && countdownTime == 0 || npcBehavior.needsFood == false && countdownTime == 0 || npcBehavior.needsMusic == false && countdownTime == 0)
        {
            StartCoroutine(StartCountdown());
        }
        else
        {
            
        }
    }

}
