using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boy_Scr : MonoBehaviour
{
    public bool Girl = false;
    public bool Boy = false;

    public Player_KillingAnimation killing;

    void OnCollisionStay(Collision collisionInfo)
    {
        GameObject g = GameObject.FindGameObjectWithTag("Player");

        if (Girl == true)
        {
            killing = g.GetComponent<Player_KillingAnimation>();
            killing.Girl = true;
            killing.Boy = false;
        }

        if (Boy == true)
        {
            killing = g.GetComponent<Player_KillingAnimation>();
            killing.Boy = true;
            killing.Girl = false;
        }


    }
}
