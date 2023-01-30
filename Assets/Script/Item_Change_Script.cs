using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Change_Script : MonoBehaviour
{
    //public Soul_id_Script SoulIDscr;

    public GameObject Item;
    public GameObject ItemOnCloset;
    float XAxis = 0;
    float YAxis = 0;
    float ZAxis = 0;

    bool once = false;

    public bool Hair_blue = false;
    public bool Hair_brown = false;

    public bool Shirt_blue = false;
    public bool Shirt_red = false;

    public bool isThisCorps = false;

    //take id from NPC and save the data , then spawn a soul and give it the right id -> right before destroying it nad after spawning it

    public bool isThisCloths = false;

    void OnCollisionStay(Collision collisionInfo)
    {
        XAxis = transform.position.x;
        YAxis = transform.position.y;
        ZAxis = transform.position.z;

        if (collisionInfo.gameObject.tag == "Ground")
        {
            if (once == true)
            {
                Destroy(this.gameObject);
            }

            if(once == false)
            {
                Instantiate(Item, new Vector3(XAxis, YAxis, ZAxis), Quaternion.identity);
                once = true;
            }
            
            /* Soul########################################
            //give soul id
            //to the soul if the changed = false!! otherwise its an older soul and not the newest!!
            bool soulChanged = GameObject.Find("Soul").GetComponent<Soul_id_Script>().changed;

            if(soulChanged == false)
            {
                //add information
                if(Hair_blue == true)
                {
                    GameObject sObject = GameObject.Find("Soul");
                    SoulIDscr = sObject.GetComponent<Soul_id_Script>();

                    SoulIDscr.Hair_blue = true;
                }

                if (Hair_brown == true)
                {
                    GameObject sObject = GameObject.Find("Soul");
                    SoulIDscr = sObject.GetComponent<Soul_id_Script>();

                    SoulIDscr.Hair_brown = true;
                }

                if (Shirt_blue == true)
                {
                    GameObject sObject = GameObject.Find("Soul");
                    SoulIDscr = sObject.GetComponent<Soul_id_Script>();

                    SoulIDscr.Shirt_blue = true;
                }

                if (Shirt_red == true)
                {
                    GameObject sObject = GameObject.Find("Soul");
                    SoulIDscr = sObject.GetComponent<Soul_id_Script>();

                    SoulIDscr.Shirt_red = true;
                }





                //change changed to true
                GameObject c = GameObject.Find("Soul");
                SoulIDscr = c.GetComponent<Soul_id_Script>();

                SoulIDscr.changed = true;*/
            //}



        }

        if (isThisCloths == true)
        {
            if (collisionInfo.gameObject.tag == "closet")
            {
                Instantiate(ItemOnCloset, new Vector3(XAxis, YAxis, ZAxis), Quaternion.identity);

                Destroy(this.gameObject);
            }
        }

        if (isThisCorps == true)
        {
            if (collisionInfo.gameObject.tag == "CorpsDestroyer")
            {
                Destroy(this.gameObject);
            }
        }

    }



}
