using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawning : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public GameObject[] nPC;
    public Sprite[] partyGuests;
    public GameObject[] spawnPoints;
    //public int guestRandomizer;
    public GameObject Clone;

    void Start()
    {
        //Spawn Rate in designer
        InvokeRepeating("NPCSpawn", 0 , designerChanges.guestSpawnRate);
        designerChanges = designerScript.GetComponent<DesignerChanges>();
        spawnPoints = GameObject.FindGameObjectsWithTag("PatrolPoints");
    }


    void Update()
    {
        
    }
    public void NPCSpawn()
    {

        StartCoroutine("SpawnNPC");

        int i = Random.Range(0,partyGuests.Length);
        Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[i];

    }

    IEnumerator SpawnNPC()
    {
        Clone = (Instantiate(nPC[Random.Range(0, nPC.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)].transform));

        yield return new WaitForSecondsRealtime(20);
        Debug.Log("Spawn the NPC");
    }
}
