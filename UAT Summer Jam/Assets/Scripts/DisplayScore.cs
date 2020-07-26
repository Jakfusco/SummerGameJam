using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour

{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public Text displayScore;
    // Start is called before the first frame update
    void Start()
    {
        designerChanges = designerScript.GetComponent<DesignerChanges>();

    }

    // Update is called once per frame
    void Update()
    {
        displayScore.text = ("Score: " + designerChanges.score);
    }
}
