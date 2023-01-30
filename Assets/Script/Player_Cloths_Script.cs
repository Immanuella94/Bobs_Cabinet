using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Cloths_Script : MonoBehaviour
{
    public int cloths = 0;
    public int maxCloths = 2;
    public bool InventoryFull = false;

    public Closet_Script closetScr; //reffering to the Closet Script

    //GUI Cloths counter
    public GameObject Shirt0;
    public GameObject Shirt1;
    public GameObject Shirt2;
    public GameObject Shirt3;

    void Start()
    {
        //Change sprite 0cloths ,1cloths, 2cloths 3cloths
        Shirt0.SetActive(true);
    }

    void Update()
    {
        Debug.Log("Cloths: " + cloths);

        if(cloths == maxCloths)
        {
            InventoryFull = true;
            Debug.Log("Inventory full, you currently carry " + cloths + " cloths.");
        }

        if(cloths != maxCloths)
        {
            InventoryFull = false;
        }

        int currentPlayerCloths = GameObject.Find("closet").GetComponent<Closet_Script>().currentPlayerCloths; //check script from closet
        //change variable curretnPlayerCloths from Closet to always be this objects cloths
        GameObject c = GameObject.FindGameObjectWithTag("closet");
        closetScr = c.GetComponent<Closet_Script>();

        closetScr.currentPlayerCloths = cloths; //always updating playercloths in closet to cloths in player (how many he is currently holding)


        //change GUI to number of cloths
        if (cloths == 0)
        {
            Shirt0.SetActive(true);
            Shirt1.SetActive(false);
            Shirt2.SetActive(false);
            Shirt3.SetActive(false);
        }

        if (cloths == 1)
        {
            Shirt0.SetActive(false);
            Shirt1.SetActive(true);
            Shirt2.SetActive(false);
            Shirt3.SetActive(false);
        }

        if (cloths == 2)
        {
            Shirt0.SetActive(false);
            Shirt1.SetActive(false);
            Shirt2.SetActive(true);
            Shirt3.SetActive(false);
        }

        if (cloths == 3)
        {
            Shirt0.SetActive(false);
            Shirt1.SetActive(false);
            Shirt2.SetActive(false);
            Shirt3.SetActive(true);
        }
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Cloths")
        {
            if (cloths != maxCloths)
            {
                if (Input.GetKey("space"))
                {
                    cloths = cloths + 1;
                }
            }
            else if (cloths == maxCloths)
            {
                if (Input.GetKey("space"))
                {
                    Debug.Log("Too many cloths, i can only carry " + maxCloths + " Cloths");
                }
            }
        }
    }

}
