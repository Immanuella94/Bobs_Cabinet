using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    float currentXAxis = 0f;
    float currentYAxis = 0f;
    float currentZAxis = 0f;

    //change goal position
    public float goalXAxis = 0f;
    public float goalYAxis = 0f;
    public float goalZAxis = 0f;

    void Update()
    {
        //Takes current X; Y and Z position
        currentXAxis = transform.position.x;
        currentYAxis = transform.position.y;
        currentZAxis = transform.position.z;

        //check if current axis is the same as the goal axis
        if (goalXAxis == currentXAxis)
        {
            if (goalYAxis == currentYAxis)
            {
                if (goalZAxis == currentZAxis)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
