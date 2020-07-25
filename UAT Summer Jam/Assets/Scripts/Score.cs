using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public Text score;
    // Update is called once per frame
    private void Start()
    {
        designerChanges = designerScript.GetComponent<DesignerChanges>();
    }
    void Update()
    {
        score.text = ("Score: " + designerChanges.score.ToString());
    }

}

