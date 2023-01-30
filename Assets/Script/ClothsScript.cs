using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothsScript : MonoBehaviour
{
    public Closet_Script ClosetScr; //call the closet script from closet

    public bool InventoryFull = false;

    //this is info for the closet
    public bool Shirt_blue = false;
    public bool Shirt_cyan = false;
    public bool Shirt_red = false;

    public int ClothsNumber = 0;

    void Start()
    {
        //spawn it in the rotation 0,0,0 , gameObject.transform.rotation = Quaternion.Euler(targetRotationX, targetRotationY, targetRotationZ);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    

    void OnCollisionStay(Collision collisionInfo)
    {

        InventoryFull = GameObject.Find("Player").GetComponent<Player_Cloths_Script>().InventoryFull;

        if (InventoryFull == false)
        {
            if (collisionInfo.gameObject.tag == "Player")
            {
                if (Input.GetKey("space"))
                {
                    //send information to other object
                    GameObject color_cloths = GameObject.FindGameObjectWithTag("closet");
                    ClosetScr = color_cloths.GetComponent<Closet_Script>();

                    //add colors that this object has
                    if(Shirt_blue == true)
                    {
                        ClosetScr.Shirt_blue = Shirt_blue;
                        //add object color plus one
                        ClosetScr.Shirt_Count_blue++;

                    }
                    if (Shirt_red == true)
                    {
                        ClosetScr.Shirt_red = Shirt_red;
                        //add object color plus one
                        ClosetScr.Shirt_Count_red++;
                    }
                    if (Shirt_cyan == true)
                    {
                        ClosetScr.Shirt_cyan = Shirt_cyan;
                        //add object color plus one
                        ClosetScr.Shirt_Count_cyan++;
                    }


                    Destroy(this.gameObject);
                }
            }
        }
    }
}
