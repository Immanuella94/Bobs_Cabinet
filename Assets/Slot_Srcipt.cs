using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot_Srcipt : MonoBehaviour
{

    public GameObject objectToSpawn;

    void OnCollisionStay(Collision collisionInfo)
    {

        if (collisionInfo.gameObject.tag == "Player")
        {
            Debug.Log("Joa berührt!");

            if (Input.GetKeyDown("space"))
            {
                Instantiate(objectToSpawn, transform.position, transform.rotation);
                Debug.Log("Pressed Spasce");

                Destroy(this.gameObject);
            }
        }
    }
}