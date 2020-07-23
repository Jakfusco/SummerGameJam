using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMeter : MonoBehaviour
{
    [SerializeField] [Range(0,200)] private float partyMeter;

    [SerializeField] private GameObject attenders;
    [SerializeField] private Collider triggerBox;

    [SerializeField] private bool needFulfilled;
    [SerializeField] private int peopleAttending;
   //[SerializeField] private int countdownTime = 1;

    private void Start()
    {
        partyMeter = 100;
        StartCoroutine(StartCountdown());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "NPC")
        {
            Debug.Log("New attendee");
            peopleAttending = peopleAttending + 1;
        }
    }

    void Update()
    {

        
    }
    public IEnumerator StartCountdown()
    {
        Debug.Log("Timer is working");
        
        while (peopleAttending >= 1 && needFulfilled == false)
        {
            Debug.Log(partyMeter + " huh");
            yield return new WaitForSeconds(1f);
           partyMeter = partyMeter - 1;
           
            
        }
    }


}
