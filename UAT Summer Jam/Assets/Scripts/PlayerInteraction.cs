using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public bool triggeringMusic;
    public bool triggeringTable;
    private GameObject triggeringNpc;
    private bool triggering;
    public GameObject foodButtons;
    public Mouse_Look mouseControls;
    public int theHealth = 100;
    public int score = 0;
    public Text redButtonText;
    public Text blueButtonText;
    public Text greenButtonText;
    public GameObject npcScript;
    public NPCBehavior npcBehavior;
    void Start()
    {
        mouseControls = GetComponent<Mouse_Look>();
        npcBehavior = npcScript.GetComponent<NPCBehavior>();
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
            redButtonText.text = "Give Pizza";
            blueButtonText.text = "Give Wings";
            greenButtonText.text = "Give Tacos";
        }
        if (other.tag == "NPC" && npcBehavior.needsConvo == true)
        {
            triggering = true;
            triggeringNpc = other.gameObject;
            redButtonText.text = "Convo1";
            blueButtonText.text = "Convo2";
            greenButtonText.text = "Convo3";
        }
        if (other.tag == "Table")
        {
            triggeringTable = true;
            triggeringNpc = other.gameObject;
            redButtonText.text = "Grab Pizza";
            blueButtonText.text = "Grab Wings";
            greenButtonText.text = "Grab Tacos";
        }
        if (other.tag == "Music")
        {
            triggeringMusic = true;
            triggeringNpc = other.gameObject;
            redButtonText.text = "Music1";
            blueButtonText.text = "Music2";
            greenButtonText.text = "Music3";
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
