using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class BodyCounterScr : MonoBehaviour
{
    int currentInt = 0;
    int latestInt = 0;

    public GameObject scullEmpty1;
    public GameObject scullEmpty2;
    public GameObject scullEmpty3;
    public GameObject scullEmpty4;

    public GameObject Counter0;
    public GameObject Counter1;
    public GameObject Counter2;
    public GameObject Counter3;
    public GameObject Counter4;

    void Update()
    {
        if (currentInt > latestInt)
        {
            //open new image
            CheckGameObject();
            latestInt = currentInt;
        }
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Shirt")
        {
            currentInt = currentInt + 1;
        }

    }

    void CheckGameObject()
    {

        if (Counter3.activeSelf)
        {

            Counter3.SetActive(false);
            scullEmpty4.SetActive(true);

        }
        else
        {
            if (Counter2.activeSelf)
            {

                Counter2.SetActive(false);
                scullEmpty3.SetActive(true);

            }
            else
            {
                if (Counter1.activeSelf)
                {

                    Counter1.SetActive(false);
                    scullEmpty2.SetActive(true);


                }
                else
                {
                    if (Counter0.activeSelf)
                    {
                        // do something, if it is not active...
                        Counter0.SetActive(false);
                        scullEmpty1.SetActive(true);

                    }
                }

                
            }

            
        }


        
            
                
            
        
    }
}
