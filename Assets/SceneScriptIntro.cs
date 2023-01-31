using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScriptIntro : MonoBehaviour
{
    public GameObject Scened1;
    public GameObject Scened2;
    public GameObject Scened3;
    public GameObject Scened4;

    public GameObject Scened1a;
    public GameObject Scened1b;
    public GameObject Scened2a;
    public GameObject Scened3a;
    public GameObject Scened3b;
    public GameObject Scened4a;
    public GameObject Backdrop;

    int sceneCounter = 0;
    bool OnlyOnce = false;

    void Update()
    {
        if(sceneCounter != 0)
        {
            if (Input.anyKeyDown)
            {
                sceneCounter = sceneCounter + 1;
            }
        }

        if (sceneCounter == 7) //4
        {
            //nextScene
            SceneManager.LoadScene(2);
        }

        if (sceneCounter == 6) //4
        {
            Scened3.SetActive(false);
            Scened3b.SetActive(false);
            Scened4.SetActive(true);
            Scened4a.SetActive(true);
        }

        if (sceneCounter == 5) //3b
        {
            Scened3a.SetActive(false);
            Scened3b.SetActive(true);
        }

        if (sceneCounter == 4) //3a
        {
            Scened2.SetActive(false);
            Scened2a.SetActive(false);
            Scened3.SetActive(true);
            Scened3a.SetActive(true);
        }

        if (sceneCounter == 3) //2
        {
            Scened1.SetActive(false);
            Scened1b.SetActive(false);
            Scened2.SetActive(true);
            Scened2a.SetActive(true);
        }

        if (sceneCounter == 2) //1b
        {
            Scened1a.SetActive(false);
            Scened1b.SetActive(true);
        }


        if (sceneCounter == 1) //1a
        {
            Scened1.SetActive(true);
            Scened1a.SetActive(true);
            Backdrop.SetActive(true);
        }

        if ((sceneCounter == 0) && (OnlyOnce == false))//1a
        {
            Backdrop.SetActive(false);
            StartCoroutine(waiter());
            OnlyOnce = true;
        }

    }

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(11f);
        sceneCounter = 1;
    }
}
