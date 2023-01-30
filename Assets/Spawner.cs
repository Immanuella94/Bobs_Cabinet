using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] npc_spawn;
    // Start is called before the first frame update
    public int SpawningNumber;
    int g = 0;
    int i = 0;
    bool isWaiting = false;
    
    void Update()
    {
        //for (; i <= SpawningNumber; i++)
        //{
            if (isWaiting == false)
            {
                if (i != SpawningNumber)
                {
                    Instantiate(npc_spawn[g], transform.position, Quaternion.identity);
                    i += 1;
                    g = g + 1;
                    if (g >= 2)
                    {
                        g = 0;
                    }
                    isWaiting = true;
                    StartCoroutine(WaitBeforeSpawn());
                    
                }
            }
                        
        //}
    }

    IEnumerator WaitBeforeSpawn()
    {
        Debug.Log("hello bugs");
        yield return new WaitForSecondsRealtime(3f);
        isWaiting = false;
        Debug.Log("bye");
    }
}
