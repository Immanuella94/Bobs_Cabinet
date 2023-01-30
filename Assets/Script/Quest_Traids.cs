using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Traids : MonoBehaviour
{

    public bool death = false;

    public Soul_Taker_Scr SoulScript;

    public bool Hair_blue = false;
    public bool Hair_brown = false;
    public bool Shirt_blue = false;
    public bool Shirt_red = false;

    void Start()
    {
        
    }

    void Update()
    {
        //send the info to the Soul_Taker (aka QuestManager)
        if (Hair_blue == true)
        {
            GameObject s = GameObject.FindGameObjectWithTag("SoulTaker");
            SoulScript = s.GetComponent<Soul_Taker_Scr>();

            SoulScript.Hair_blue = true;
        }

        if (Hair_brown == true)
        {
            GameObject s1 = GameObject.FindGameObjectWithTag("SoulTaker");
            SoulScript = s1.GetComponent<Soul_Taker_Scr>();

            SoulScript.Hair_brown = true;
        }

        if (Shirt_blue == true)
        {
            GameObject s2 = GameObject.FindGameObjectWithTag("SoulTaker");
            SoulScript = s2.GetComponent<Soul_Taker_Scr>();

            SoulScript.Shirt_blue = true;
        }

        if (Shirt_red == true)
        {
            GameObject s3 = GameObject.FindGameObjectWithTag("SoulTaker");
            SoulScript = s3.GetComponent<Soul_Taker_Scr>();

            SoulScript.Shirt_red = true;
        }

    }
}
