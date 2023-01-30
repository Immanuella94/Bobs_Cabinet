/*using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Shirt_Item : MonoBehaviour
{
    public PlayerInventory1 inventoryScr;
    public GameObject Player;

    void OnCollisionStay(Collision collisionInfo)
    {
        if ((collisionInfo.gameObject.tag == "Player") && (Input.GetKeyDown("space")))
        {
            inventoryScr = Player.GetComponent<PlayerInventory>();

            if (inventoryScr.HasCloths == false)
            {
                inventoryScr.HasCloths = true;
                Destroy(this.gameObject);
            }

        }
    }
}*/

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Shirt_Item1 : MonoBehaviour
{
    public PlayerInventory1 inventoryScr;

    void OnCollisionStay(Collision collisionInfo)
    {
        if ((collisionInfo.gameObject.tag == "Player") && (Input.GetKeyDown("space")))
        {
            inventoryScr = collisionInfo.gameObject.GetComponent<PlayerInventory1>();

            if (inventoryScr.HasCloths == false)
            {
                inventoryScr.HasCloths = true;
                Destroy(this.gameObject);
            }

        }
    }
}