using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shirt_Item_Scr : MonoBehaviour
{
    public GameObject Shirt_obj;
    float XAxis = 0;
    float YAxis = 0;
    float ZAxis = 0;

    //once on the ground change it into an Shirt object to be collectable!
    void OnCollisionStay(Collision collisionInfo)
    {
        XAxis = transform.position.x;
        YAxis = transform.position.y;
        ZAxis = transform.position.z;

        if (collisionInfo.gameObject.tag == "Ground")
        {
            Instantiate(Shirt_obj, new Vector3(XAxis, YAxis, ZAxis), Quaternion.identity);
            Destroy(this.gameObject);
        }

    }

}
