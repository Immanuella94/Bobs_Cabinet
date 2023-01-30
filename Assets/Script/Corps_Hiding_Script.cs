using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corps_Hiding_Script : MonoBehaviour
{
    public Player_Corps_Script plCorpsScr;
    public GameObject CorpsItem;

    float XAxis = 0;
    float YAxis = 0;
    float ZAxis = 0;

    void Start()
    {
        XAxis = transform.position.x;
        YAxis = transform.position.y;
        ZAxis = transform.position.z;
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        bool corpsInHand = GameObject.Find("Player").GetComponent<Player_Corps_Script>().corpsInHand; //check script from player

        if (corpsInHand == true)
        {
            if (collisionInfo.gameObject.tag == "Player")
            {
                if (Input.GetKey("space"))
                {
                    GameObject g = GameObject.FindGameObjectWithTag("Player");
                    plCorpsScr = g.GetComponent<Player_Corps_Script>();

                    plCorpsScr.corpsInHand = false;

                    //drop a corps item on the deposit
                    Instantiate(CorpsItem, new Vector3(XAxis, YAxis + 5f, ZAxis), Quaternion.identity);

                    Debug.Log("Player hides the body in the box");

                    //change Box equal to destroy, but also destroy self to change object
                }
            }
        } else if (corpsInHand == false)
        {
            Debug.Log("No Corps to hide!");
        }
    }
}
