using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMeter : MonoBehaviour
{
    [SerializeField] private float partyMeter;

    [SerializeField] private GameObject attenders;
    [SerializeField] private Collider triggerBox;

    [SerializeField] private bool needFulfilled;
    [SerializeField] private int peopleAttending;

    private void Start()
    {
        partyMeter = 100;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            peopleAttending = peopleAttending + 1;
            Attendance();
        }
    }

    void Attendance()
    {
        if(peopleAttending >= 1)
        {
            if (needFulfilled == false)
            {
                partyMeter = partyMeter - (peopleAttending * 1 * Time.deltaTime);
                Debug.Log(partyMeter);
            }

            else if (needFulfilled == true)
            {
                partyMeter = partyMeter + 5;
                Debug.Log(partyMeter + "huh");
            }
        }
    }
}
