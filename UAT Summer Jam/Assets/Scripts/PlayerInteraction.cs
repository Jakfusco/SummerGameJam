using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject designerScript;
    public DesignerChanges designerChanges;
    public bool triggeringMusic;
    public bool triggeringTable;
    private GameObject triggeringNpc;
    public bool triggering;
    public GameObject foodButtons;
    public Mouse_Look mouseControls;
    public int score = 0;
    public Text redButtonText;
    public Text blueButtonText;
    public Text greenButtonText;
    public GameObject npcScript;
    public NPCBehavior npcBehavior;
    public GameObject buttonScript;
    public Buttons buttons;
    public bool haspizza;
    public bool haswings;
    public bool hastacos;
    public GameObject canvas;
    void Start()
    {
        mouseControls = GetComponent<Mouse_Look>();
        npcBehavior = npcScript.GetComponent<NPCBehavior>();
        designerChanges = designerScript.GetComponent<DesignerChanges>();
        buttons = buttonScript.GetComponent<Buttons>();
       // npcScript = GameObject.Find("NPC");
    }

    void Update()
    {
        if (triggering || triggeringTable == true || triggeringMusic == true)
        {
            //foodButtons.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            // buttons.buttonParent.SetActive(true);
            canvas.GetComponent<Canvas>().enabled = true;
        }
        else
        {
           // foodButtons.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            // buttons.buttonParent.SetActive(false);
            canvas.GetComponent<Canvas>().enabled = false;
        }
        if (npcBehavior == null)
        {
            return;
        }

    }
    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "NPC")
        {
            triggering = true;
            triggeringNpc = other.gameObject;
            redButtonText.text = designerChanges.redButtonFoodText;
            blueButtonText.text = designerChanges.blueButtonFoodText;
            greenButtonText.text = designerChanges.greenButtonFoodText;
            buttons.nPC = other.gameObject;
            npcBehavior = other.gameObject.GetComponent<NPCBehavior>();
            npcScript = other.gameObject;
        }
        if (other.tag == "NPC" && npcBehavior.needsConvo == true || other.tag == "NPC" && npcBehavior.npcState == 2)
        {
            triggering = true;
            triggeringNpc = other.gameObject;
            redButtonText.text = designerChanges.redButtonConversationText;
            blueButtonText.text = designerChanges.blueButtonConversationText;
            greenButtonText.text = designerChanges.greenButtonConversationText;
        }
        if (other.tag == "Table")
        {
            triggeringTable = true;
            triggeringNpc = other.gameObject;
            redButtonText.text = designerChanges.redButtonTableText;
            blueButtonText.text = designerChanges.blueButtonTableText;
            greenButtonText.text = designerChanges.greenButtonTableText;
        }
        if (other.tag == "Music")
        {
            triggeringMusic = true;
            triggeringNpc = other.gameObject;
            redButtonText.text = designerChanges.redButtonMusicText;
            blueButtonText.text = designerChanges.blueButtonMusicText;
            greenButtonText.text = designerChanges.greenButtonMusicText;
        }
    }
    void OnTriggerExit (Collider other)
    {
        if (other.tag == "NPC")
        {
            triggering = false;
            triggeringNpc = null;
            npcScript = null;
            buttons.nPC = null;
            npcBehavior = null;
        }
        if (other.tag == "Table")
        {
            triggeringTable = false;
            triggeringNpc = null;
            
        }
        if (other.tag == "Music")
        {
            triggeringMusic = false;
            triggeringNpc = null;
        }
    }
}
