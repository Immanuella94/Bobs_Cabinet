using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingSoundAnimScr : MonoBehaviour
{
    public AudioSource KillingAnim;
    public AudioClip killingSound;

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(0.7f);

        KillingAnim.clip = killingSound;
        KillingAnim.Play();
        Debug.Log("kill anim started");
    }

    void OnEnable()
    {
        StartCoroutine(waiter());
        
    }

}
