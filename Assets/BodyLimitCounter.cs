using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyLimitCounter : MonoBehaviour
{
    public int MaxBody = 2;
    public int currentBodyCount = 0;

    void Update()
    {
        if(currentBodyCount >= MaxBody)
        {
            //GameOver screen - change scene
            Debug.Log("GAME OVER BC TOO MANY CORPSES)");
        }

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "NormalItem")
        {
            Debug.Log("Eins mehr: " + currentBodyCount);

            currentBodyCount = currentBodyCount + 1;
        }
    }

}
