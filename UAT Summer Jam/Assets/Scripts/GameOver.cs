using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    void Update()
    {
        if (designerChanges.partyMeter == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
    private void Start()
    {
        designerChanges = designerScript.GetComponent<DesignerChanges>();
    }
}
