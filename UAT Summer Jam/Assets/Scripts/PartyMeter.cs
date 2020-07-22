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
        if (other.gameObject.tag == "NPC")
        {
            Debug.Log("New attendee");
            peopleAttending = peopleAttending + 1;
        }
    }

    private void Update()
    {
        while (peopleAttending >= 1 & needFulfilled == true)
        {
            partyMeter = partyMeter + 5;
            Debug.Log(partyMeter + "huh");
        }
    }

}
