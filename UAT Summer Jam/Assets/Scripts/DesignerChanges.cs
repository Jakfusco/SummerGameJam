using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignerChanges : MonoBehaviour
{
    public int score;
    [Range(0, 200)] public int partyMeter = 100;
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
    public int partyMeterDecreaseRate = 1;
    public int partyMeterDecreaseSpeed = 1;
    public float mouseSensitivity = 100f;







}
