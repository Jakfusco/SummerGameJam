using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawning : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public GameObject nPC;
    public GameObject[] partyGuests;
    public int guestRandomizer;
    public GameObject[] guest;
    public Transform parent;
    public GameObject Clone;

    public List<Transform> spawnPointList;
    public float spawnDistance;


    void Start()
    {
        //Spawn Rate in designer
        InvokeRepeating("NPCSpawn", 0 , designerChanges.guestSpawnRate);
        designerChanges = designerScript.GetComponent<DesignerChanges>();
    }


    void Update()
    {
        
    }
    public void NPCSpawn()
    {
        //Instantiate(nPC);

        Transform spawnPoint = spawnPointList[Random.Range(0, spawnPointList.Count)];

        Vector3 randomVector = Random.insideUnitSphere;
        Vector3 newPosition = spawnPoint.position + (randomVector * spawnDistance);

        int i = Random.Range(0, partyGuests.Length);
        Clone = (Instantiate(partyGuests[i], new Vector3(newPosition.x, spawnPoint.position.y, newPosition.z), Quaternion.identity)) as GameObject;

       // Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[i];

    }
}
