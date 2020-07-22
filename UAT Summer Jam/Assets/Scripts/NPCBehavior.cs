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
    public int whichMusic;
    public bool wantsMusic1;
    public bool wantsMusic2;
    public bool wantsMusic3;
    public int whichConvo;
    public bool wantsConvo1;
    public bool wantsConvo2;
    public bool wantsConvo3;

    public void RandomState()
    {
        //change to 1-3 for full launch
       npcState =  Random.Range(2, 2);
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
            whichConvo = Random.Range(1, 3);
            if (whichConvo == 1)
            {
                wantsConvo1 = true;
            }
            if (whichConvo == 2)
            {
                wantsConvo2 = true;
            }
            if (whichConvo == 3)
            {
                wantsConvo3 = true;
            }
        }
        if (npcState == 3)
        {
            needsMusic = true;
            whichMusic = Random.Range(1, 3);
            if (whichMusic == 1)
            {
                wantsMusic1 = true;
            }
            if (whichMusic == 2)
            {
                wantsMusic2 = true;
            }
            if (whichMusic == 3)
            {
                wantsMusic3 = true;
            }
        }
        if (npcState == 0)
        {
            needsNothing = true;
        }
    }


}
