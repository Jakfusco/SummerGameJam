using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawning : MonoBehaviour
{
    public GameObject nPC;
    public Sprite[] partyGuests;
    public int guestRandomizer;
    public GameObject designerScript;
    public DesignerChanges designerChanges;

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
        GameObject Clone;
        Clone = (Instantiate(nPC)) as GameObject;
        //  switch (guestRandomizer)
        // {
        //    case 1:
        //       Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[0];
        //     break;
        //  case 2:
        //      Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[1];
        //       break;
        // case 3:
        //     Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[2];
        //      break;
        //  case 4:
        //       Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[3];
        //       break;
        //   case 5:
        //       Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[4];
        //      break;
        //  case 6:
        //       Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[5];
        //       break;
        //  case 7:
        //      Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[6];
        //     break;
        // case 8:
        //      Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[7];
        //     break;
        // }
        int i = Random.Range(0,partyGuests.Length);
        Clone.GetComponent<SpriteRenderer>().sprite = partyGuests[i];

    }
}
