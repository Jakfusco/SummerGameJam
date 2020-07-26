using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPartyMeter : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public float displayPartyMeter;
    public int max;
    public int current;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayPartyMeter = designerChanges.partyMeter;
    }
}
