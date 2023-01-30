using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet_Script : MonoBehaviour
{
    public Player_Cloths_Script plClothsScr; //call the player cloths script
    public ClothsScript ClothsScr; //call the cloths cloths script

    public GameObject CyanItem;
    public GameObject RedItem;
    public GameObject BlueItem;

    float XAxis = 0;
    float YAxis = 0;
    float ZAxis = 0;

    public int maxCloths = 3; //how many cloths can be placed on the closet
    public int currentPlayerCloths = 0; //how many cloths has the player currently //call this from the other script
    int currentCloths = 0; //how many cloths are placed on the closet currently

    /// how many cloths and what color the player collect
    //this is info for the closet
    public bool Shirt_blue = false;
    public bool Shirt_cyan = false;
    public bool Shirt_red = false;

    //how many you have from one collected
    public int Shirt_Count_blue = 0;
    public int Shirt_Count_cyan = 0;
    public int Shirt_Count_red = 0;



    void Start()
    {
        //only supposed to have 6 cloths at max or 3 idk

        XAxis = transform.position.x;
        YAxis = transform.position.y;
        ZAxis = transform.position.z;


    }


    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            if (Input.GetKey("space")) //if only once go with GetKeyDown
            {
                if((currentPlayerCloths != 0) && (currentCloths != maxCloths))
                {
                    if(Shirt_cyan == true)
                    {
                        if(Shirt_Count_cyan != 0)
                        {
                            //spawns objekt
                            Instantiate(CyanItem, new Vector3(XAxis, YAxis + 7f, ZAxis), Quaternion.identity);
                            currentCloths = currentCloths + 1;
                            Shirt_Count_cyan = Shirt_Count_cyan - 1;

                            if (Shirt_Count_cyan == 0)
                            {
                                Shirt_cyan = false;
                            }
                        }
                    }

                    if (Shirt_blue == true)
                    {
                        if (Shirt_Count_blue != 0)
                        {
                            //spawns objet
                            Instantiate(BlueItem, new Vector3(XAxis, YAxis + 5f, ZAxis), Quaternion.identity);
                            currentCloths = currentCloths + 1;
                            Shirt_Count_blue = Shirt_Count_blue - 1;

                            if (Shirt_Count_cyan == 0)
                            {
                                Shirt_blue = false;
                            }
                        }
                    }

                    if (Shirt_red == true)
                    {
                        if (Shirt_Count_red != 0)
                        {
                            //spawns objet
                            Instantiate(RedItem, new Vector3(XAxis, YAxis + 5f, ZAxis), Quaternion.identity);
                            currentCloths = currentCloths + 1;
                            Shirt_Count_red = Shirt_Count_red - 1;

                            if (Shirt_Count_red == 0)
                            {
                                Shirt_red = false;
                            }
                        }
                    }

                    //reffer to the objects script , the int cloths
                    int plCloths = GameObject.Find("Player").GetComponent<Player_Cloths_Script>().cloths;
                    GameObject p_c = GameObject.FindGameObjectWithTag("Player");
                    plClothsScr = p_c.GetComponent<Player_Cloths_Script>();

                    //take one cloths away from player
                    plClothsScr.cloths = plClothsScr.cloths - 1;
                }

                //change cloths from player - 1 for each taken cloths
            }
        }
    }
}
