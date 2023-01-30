using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Drop : MonoBehaviour
{
    public GameObject ShirtSkin_Item;

    float XAxis = 0;
    float YAxis = 0;
    float ZAxis = 0;

    public GameObject PlayerObj;

    void Update()
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
                //wait a half a sec
                StartCoroutine(waiter());
                Instantiate(ShirtSkin_Item, new Vector3(XAxis + 3, YAxis + 8f, ZAxis), Quaternion.identity);//y +5f
                PlayerObj.GetComponent<Player_KillingAnimation>()._Start = true;
                Destroy(this.gameObject);
            }
        }
    }

    IEnumerator waiter()
    {

        //Wait for half a second
        yield return new WaitForSecondsRealtime(0.5f);

    }
}
