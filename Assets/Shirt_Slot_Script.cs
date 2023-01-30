using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shirt_Slot_Script : MonoBehaviour
{
    //if pressed space, the object deletes itself,
    //sets Slot_Script which is being on the shirt back to empty and
    //sets player inv to holding cloths


    public GameObject objectToSpawn;


    public bool QuestItem = false;

    //to place a shit away!
    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            Debug.Log("Joa berührt!");

            if (Input.GetKeyDown("space"))
            {
                //spawns slot
                Instantiate(objectToSpawn, transform.position, transform.rotation);
                Debug.Log("Pressed Spasce");
                Destroy(this.gameObject);
            }
        }
    }


}
