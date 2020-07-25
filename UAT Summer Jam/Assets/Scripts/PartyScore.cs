using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartyScore : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public Text partyMeter;
    // Update is called once per frame
    private void Start()
    {
        designerChanges = designerScript.GetComponent<DesignerChanges>();
    }
    void Update()
    {
        partyMeter.text = ("Party Meter: " + designerChanges.partyMeter.ToString());
    }

}

