using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawning : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public GameObject nPC;
    public Sprite[] partyGuests;
    public int guestRandomizer;
    public GameObject[] guest;
    public Transform parent;
    public GameObject Clone;


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

        Clone = (Instantiate(nPC, parent)) as GameObject;
        int i = Random.Range(0, partyGuests.Length);
        Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[i];

    }
}
