using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Drop : MonoBehaviour
{
    public QuestSystem QSystem;

    public GameObject ShirtSkin_Item;

    public bool Quest1 = false;
    public bool Quest2 = false;
    public bool Quest3 = false;
 
    float XAxis = 0;
    float YAxis = 0;
    float ZAxis = 0;

    public GameObject PlayerObj;

    private bool readyToDrop = false;

    void Update()
    {

        XAxis = transform.position.x;
        YAxis = transform.position.y;
        ZAxis = transform.position.z;
        if (Input.GetKeyDown("q"))
        {
            if (readyToDrop)
            {
                readyToDrop = false;
                //wait a half a sec
                StartCoroutine(waiter());
            }
        }

    }

    
    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            readyToDrop = true;
        }
    }

    IEnumerator waiter()
    {

        //Wait for half a second
        yield return new WaitForSecondsRealtime(0.5f);
        //Debug.Log("Shirt spawned");
        Instantiate(ShirtSkin_Item, new Vector3(XAxis, YAxis + 2, ZAxis), Quaternion.identity);//y +5f x =3
        PlayerObj.GetComponent<Player_KillingAnimation>()._Start = true;

        if(Quest1 == true)
        {
            //change the bool fromt he other script
            GameObject g = GameObject.FindGameObjectWithTag("Player");
            QSystem = g.GetComponent<QuestSystem>();

            QSystem.QuestNpcDeath1 = true;

        }

        if (Quest2 == true)
        {
            //change the bool fromt he other script
            GameObject g = GameObject.FindGameObjectWithTag("Player");
            QSystem = g.GetComponent<QuestSystem>();

            QSystem.QuestNpcDeath2 = true;
        }

        if (Quest3 == true)
        {
            //change the bool fromt he other script
            GameObject g = GameObject.FindGameObjectWithTag("Player");
            QSystem = g.GetComponent<QuestSystem>();

            QSystem.QuestNpcDeath3 = true;
        }

        Destroy(this.gameObject);

    }
}
