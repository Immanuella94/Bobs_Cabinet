using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Cloths_Script : MonoBehaviour
{
    public GameObject Shirt0;
    public GameObject Shirt1;
    public GameObject Shirt2;
    public GameObject Shirt3;

    int cloths = 0;

    void Start()
    {
        //Change sprite 0cloths ,1cloths, 2cloths 3cloths
        Shirt0.SetActive(true);
    }


    void Update()
    {
        if (cloths == 0)
        {
            Shirt0.SetActive(true);
            Shirt1.SetActive(false);
            Shirt2.SetActive(false);
            Shirt3.SetActive(false);
        }

        if (cloths == 1)
        {
            Shirt0.SetActive(false);
            Shirt1.SetActive(true);
            Shirt2.SetActive(false);
            Shirt3.SetActive(false);
        }

        if (cloths == 2)
        {
            Shirt0.SetActive(false);
            Shirt1.SetActive(false);
            Shirt2.SetActive(true);
            Shirt3.SetActive(false);
        }

        if (cloths == 3)
        {
            Shirt0.SetActive(false);
            Shirt1.SetActive(false);
            Shirt2.SetActive(false);
            Shirt3.SetActive(true);
        }
    }
}
