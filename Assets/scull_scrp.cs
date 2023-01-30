using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scull_scrp : MonoBehaviour
{
    public GameObject SparkleObj;

    void OnCollisionStay(Collision collisionInfo)
    {

        //Check to carry shirt ITEMS FROM THE GROUND
        if (collisionInfo.gameObject.tag == "Slot")
        {
            Debug.Log("hit it");
            Instantiate(SparkleObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "Slot-Vertically")
        {
            Instantiate(SparkleObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_ClosetVertically")
        {
            Instantiate(SparkleObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_ClosetMINI")
        {
            Instantiate(SparkleObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_Closet")
        {
            Instantiate(SparkleObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

    }
}
