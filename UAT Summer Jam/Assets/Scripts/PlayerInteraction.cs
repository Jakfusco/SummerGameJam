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
    private bool triggering;
    public GameObject foodButtons;
    public Mouse_Look mouseControls;
    public int score = 0;
    public Text redButtonText;
    public Text blueButtonText;
    public Text greenButtonText;
    public GameObject npcScript;
    public NPCBehavior npcBehavior;
    public bool haspizza;
    public bool haswings;
    public bool hastacos;
    void Start()
    {
        mouseControls = GetComponent<Mouse_Look>();
        npcBehavior = npcScript.GetComponent<NPCBehavior>();
        designerChanges = designerScript.GetComponent<DesignerChanges>();
    }

    void Update()
    {
        if (triggering || triggeringTable == true || triggeringMusic == true)
        {
            foodButtons.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }else
        {
            foodButtons.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
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
