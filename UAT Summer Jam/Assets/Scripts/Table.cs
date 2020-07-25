using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table : MonoBehaviour
{
    public Button m_RedButton, m_BlueButton, m_GreenButton;
    public GameObject playerScript;
    public PlayerInteraction playerInteraction;
    void Start()
    {
        m_RedButton.onClick.AddListener(RedButtonClick);
        m_BlueButton.onClick.AddListener(BlueButtonClick);
        m_GreenButton.onClick.AddListener(GreenButtonClick);
        playerInteraction = playerScript.GetComponent<PlayerInteraction>();
    }
    void Update()
    {
        
    }
    void RedButtonClick()
    {
        if (playerInteraction.triggeringTable == true)
        {
            playerInteraction.haspizza = true;
        }
    }
    void BlueButtonClick()  
    {
        if (playerInteraction.triggeringTable == true)
        {
            playerInteraction.haswings = true;
        }
    }
    void GreenButtonClick()
    {
        if (playerInteraction.triggeringTable == true)
        {
            playerInteraction.hastacos = true;
        }
    }
}
