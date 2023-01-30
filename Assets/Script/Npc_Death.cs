using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc_Death : MonoBehaviour
{
    public GameObject Cloths_Item;
    public GameObject Corps_Item;
    public GameObject Soul_Item;
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
        if (collisionInfo.gameObject.tag == "Player")
        {
            if (Input.GetKey("q"))
            {
                Instantiate(Cloths_Item, new Vector3(XAxis + 3, YAxis + 5f, ZAxis), Quaternion.identity);
                Instantiate(Corps_Item, new Vector3(XAxis, YAxis + 5f, ZAxis ), Quaternion.identity);
                Instantiate(Soul_Item, new Vector3(XAxis - 3, YAxis + 5f, ZAxis), Quaternion.identity);
                Destroy(this.gameObject);
            }
        }
    }

}
