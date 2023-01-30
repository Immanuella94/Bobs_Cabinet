using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corps_Collecting : MonoBehaviour
{
    public Player_Corps_Script plCorpsScr;

    void OnCollisionStay(Collision collisionInfo)
    {
        bool corpsInHand = GameObject.Find("Player").GetComponent<Player_Corps_Script>().corpsInHand; //check script from player

        if (corpsInHand == false)
        {
            if (collisionInfo.gameObject.tag == "Player")
            {
                if (Input.GetKey("space")) //if only once go with GetKeyDown
                {
                    //set Player_Corps_Script corpsInHand to true
                    GameObject g = GameObject.FindGameObjectWithTag("Player");
                    plCorpsScr = g.GetComponent<Player_Corps_Script>();

                    plCorpsScr.corpsInHand = true;

                    Destroy(this.gameObject);

                    Debug.Log("Collected one Corps");
                }
            }
        }
    }
}
