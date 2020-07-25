using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkingPoints : MonoBehaviour
{
    public Transform[] walkPoints;
    private int destination = 0;
    private NavMeshAgent NPC;

    private float timeToWait = 5f;
    private float currentTimeWaited = 0f;
    private bool timerStarted = false;

    private void Start()
    {
        //walkPoints = GameObject.FindGameObjectsWithTag("PatrolPoints");
        NPC = GetComponent<NavMeshAgent>();
        //InvokeRepeating("GotoNextPosition", 0, 5);
        NPC.autoBraking = true;

        timerStarted = true;
    }
    private void Update()
    {
        if(currentTimeWaited < timeToWait)
        {
            currentTimeWaited = currentTimeWaited + Time.deltaTime;
        }

        if(currentTimeWaited >= timeToWait)
        {
            if (!NPC.pathPending)
            GotoNextPosition();
            ResetTimer();
        }  
    }

    void GotoNextPosition()
    {
        if (walkPoints.Length == 0)
            return;
        NPC.destination = walkPoints[destination].position;

        destination = Random.Range(0, walkPoints.Length);
        Debug.Log(destination);
    }

    void ResetTimer()
    {
        timerStarted = true;
        currentTimeWaited = 0f;

        //Debug.Log("Timer has reset");
    }
}
