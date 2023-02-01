using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTutorial : MonoBehaviour
{
    public GameObject Tutorial1;
    public GameObject Tutorial2;
    public GameObject Tutorial3;
    public GameObject Tutorial4;
    public GameObject Tutorial5;
    public GameObject Tutorial6;
    public GameObject Tutorial7;
    //bool Once = false;
    int Start = 1;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            Start = Start + 1;
        }

        if (Start == 8)
        {
            Tutorial7.SetActive(false);

        }

        if (Start == 7)
        {
            Tutorial7.SetActive(true);
            Tutorial6.SetActive(false);

        }

        if (Start == 6)
        {
            Tutorial6.SetActive(true);
            Tutorial5.SetActive(false);

        }

        if (Start == 5)
        {
            Tutorial5.SetActive(true);
            Tutorial4.SetActive(false);

        }

        if (Start == 4)
        {
            Tutorial4.SetActive(true);
            Tutorial3.SetActive(false);

        }

        if (Start == 3)
        {
            Tutorial3.SetActive(true);
            Tutorial2.SetActive(false);

        }

        if (Start == 2)
        {
            Tutorial2.SetActive(true);
            Tutorial1.SetActive(false);

        }

        if (Start == 1)
        {
            Tutorial1.SetActive(true);
        }

        

        
    }

}
