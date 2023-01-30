using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corps_Spezial_Item : MonoBehaviour
{
    bool setDeath = false;
    public Quest_Traids QuestTraidsScr;
    public Item_Change_Script Item_Change_Script;

    public GameObject Cloths_Item; //specify the item only this npc has
    public GameObject Corps_Item; //specify the item only this npc has
    public GameObject Soul_Item; //Normal soul item everyone has, it's id will be changed
    float XAxis = 0;
    float YAxis = 0;
    float ZAxis = 0;

    bool once = false;


    public bool Hair_blue = false;
    public bool Hair_brown = false;

    public bool Shirt_blue = false;
    public bool Shirt_red = false;

    //this is needed for the Soul_Id
    public int Npc_behaviour = 0; //decide which colour belongs to which number, for example -> 0 = dark_blue_cloths , 1 = red_cloths ; 0 = brown_hair ; 1 = dark_blue_hair
    public int Npc_hair = 0;
    public int Npc_cloths = 0;

    int LilTimer = 0;
    bool startTimer = false;

    void Start()
    {

        XAxis = transform.position.x;
        YAxis = transform.position.y;
        ZAxis = transform.position.z;

    }

    void LateUpdate()
    {
        if(startTimer == true)
        {
            LilTimer = LilTimer + 1;
        }
        if(setDeath == true)
        {

            if(LilTimer == 10)
            {
                Destroy(this.gameObject);
            }

        }
    }


    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            if (Input.GetKey("q"))
            {
                if(once == false)
                {
                    Instantiate(Cloths_Item, new Vector3(XAxis + 3, YAxis + 5f, ZAxis), Quaternion.identity);
                    Instantiate(Corps_Item, new Vector3(XAxis, YAxis + 5f, ZAxis), Quaternion.identity);
                    Instantiate(Soul_Item, new Vector3(XAxis - 3, YAxis + 5f, ZAxis), Quaternion.identity);
                    once = true;
                }
                

                //change the id of the soul item after spawning it! //change it's hair , cloths AND behaviour!

                //Save the shirt color in soulItem

                //save the soul id in soulItem

                ///OOORRRR SPWAN soul item with these traits ;D
                if(Hair_blue == true)
                {
                    GameObject sItem = GameObject.Find("Soul_Item");
                    Item_Change_Script = sItem.GetComponent<Item_Change_Script>();

                    Item_Change_Script.Hair_blue = true;
                }

                if (Hair_brown == true)
                {
                    GameObject sItem = GameObject.Find("Soul_Item");
                    Item_Change_Script = sItem.GetComponent<Item_Change_Script>();

                    Item_Change_Script.Hair_brown = true;
                }

                if (Shirt_blue == true)
                {
                    GameObject sItem = GameObject.Find("Soul_Item");
                    Item_Change_Script = sItem.GetComponent<Item_Change_Script>();

                    Item_Change_Script.Shirt_blue = true;
                }

                if (Shirt_red == true)
                {
                    GameObject sItem = GameObject.Find("Soul_Item");
                    Item_Change_Script = sItem.GetComponent<Item_Change_Script>();

                    Item_Change_Script.Shirt_red = true;
                }



                GameObject n = GameObject.FindGameObjectWithTag("Npc");
                QuestTraidsScr = n.GetComponent<Quest_Traids>();

                QuestTraidsScr.death = true;

                setDeath = true;
                startTimer = true;
                //Destroy(this.gameObject);
            }
        }
    }

}
