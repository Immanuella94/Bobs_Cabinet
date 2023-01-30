using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RackSoundScr : MonoBehaviour
{
    public AudioSource ThisGameObj;
    public AudioClip rackSound;

    public bool NotStartingObject = true;

    void Start()
    {
        if (NotStartingObject == true)
        {
            ThisGameObj.clip = rackSound;
            ThisGameObj.Play();
        }
    }

}
