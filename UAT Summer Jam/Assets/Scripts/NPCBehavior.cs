using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    public bool needsFood;
    public int whichFood;
    public bool wantspizza;
    public bool wantswings;
    public bool wantstacos;
    public bool wantsnoFood;
    public bool needsConvo;
    public bool needsMusic;
    public bool needsNothing;
    public float npcState=0f;
    public bool haspizza;
    public bool haswings;
    public bool hastacos;

    public void RandomState()
    {
        //change to 1-3 for full launch
       npcState =  Random.Range(1, 1);
        if (npcState == 1)
        {
            needsFood = true;
            whichFood = Random.Range(1, 3);
            if (whichFood == 1)
            {
                wantspizza = true;
            }
            if (whichFood == 2)
            {
                wantswings = true;
            }
            if (whichFood == 3)
            {
                wantstacos = true;
            }
        }
        if (npcState == 2)
        {
            needsConvo = true;
        }
        if (npcState == 3)
        {
            needsMusic = true;
        }
        if (npcState == 0)
        {
            needsNothing = true;
        }
    }


}
