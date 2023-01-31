using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LooseScreenScr : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    int point = 0;

    void Update()
    {
        if (Input.anyKeyDown)
        {
            point = point + 1;
        }

        if (point >= 3)
        {
            SceneManager.LoadScene(0);
        }

        if (point == 1)
        {
            Text2.SetActive(true);
            Text1.SetActive(false);
        }

        if (point == 0)
        {
            Text1.SetActive(true);
            Text2.SetActive(false);
        }

        


        

        
    }
}
