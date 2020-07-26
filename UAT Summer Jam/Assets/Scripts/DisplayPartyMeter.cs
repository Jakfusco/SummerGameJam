using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPartyMeter : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public Slider partyMeterSlider;
    // Start is called before the first frame update

    private void Start()
    {
        designerScript = GameObject.Find("Designer Changes");
        designerChanges = designerScript.GetComponent<DesignerChanges>();
    }
    private void Update()
    {
        SetPartyMeter(designerChanges.partyMeter);
    }
    public void SetPartyMeter (float partyMeter)
    {
        partyMeter = designerChanges.partyMeter;
        partyMeterSlider.value = partyMeter;
    }

   
}
