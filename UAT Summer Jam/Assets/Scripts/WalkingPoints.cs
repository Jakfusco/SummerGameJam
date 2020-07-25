using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkingPoints : MonoBehaviour
{
    public List<Transform> walkPoints = new List<Transform>();
    //public Transform[] walkingPoints = new Transform[56];
    private int destination = 0;
    private NavMeshAgent NPC;

    public GameObject[] gameWalkPoints;

    private float timeToWait = 25f;
    private float currentTimeWaited = 0f;
    private bool timerStarted = false;

    private void Start()
    {
        NPC = GetComponent<NavMeshAgent>();

        NPC.autoBraking = true;

        GameObject[] walkPointObjects = GameObject.FindGameObjectsWithTag("PatrolPoints");

        foreach(GameObject walkPoint in walkPointObjects)
        {
            walkPoints.Add(walkPoint.transform);
        }

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
        if (walkPoints.Count == 0)
            return;
        NPC.destination = walkPoints[destination].position;

        destination = Random.Range(0, walkPoints.Count);
        Debug.Log(destination);
    }

    void ResetTimer()
    {
        timerStarted = true;
        currentTimeWaited = 0f;
    }
}
