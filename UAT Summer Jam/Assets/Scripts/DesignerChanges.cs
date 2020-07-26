using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesignerChanges : MonoBehaviour
{
    public int score;
    [Range(0, 200)] public float partyMeter = 100;
    public string redButtonFoodText = "Give Pizza";
    public string blueButtonFoodText = "Give Wings";
    public string greenButtonFoodText = "Give Tacos";
    public string redButtonConversationText = "Convo1";
    public string blueButtonConversationText = "Convo2";
    public string greenButtonConversationText = "Convo3";
    public string redButtonTableText = "Grab Pizza";
    public string blueButtonTableText = "Grab Wings";
    public string greenButtonTableText = "Grab Tacos";
    public string redButtonMusicText = "Music1";
    public string blueButtonMusicText = "Music2";
    public string greenButtonMusicText = "Music3";
    public int perfectPartyMeterIncrease = 25;
    public int okPartyMeterIncrease = 10;
    public int perfectScoreIncrease = 25;
    public int okScoreIncrease = 10;
    public int guestSpawnRate = 10;
    public int guestNeedsInterval = 10;
    public int guestNeedsReset = 10;
    public float partyMeterDecreaseRate = 1;
    public float partyMeterDecreaseSpeed = 1;
    public float mouseSensitivity = 100f;

    private void Update()
    {
        if (partyMeter <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if(partyMeter > 200)
        {
            partyMeter = 200;
        }
    }





}
