using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CounterGameOver : MonoBehaviour
{
    void OnEnable()
    {
        //maybe wait a few seconds then game over!!
       
            StartCoroutine(waiter());
        
        
    }

    IEnumerator waiter()
    {
        Debug.Log("Game Over");
        yield return new WaitForSecondsRealtime(3f);
        //go to game over scene
        SceneManager.LoadScene(3);
    }
}
