using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTaps : MonoBehaviour
{
    public bool Questa = false;
    public bool Questb = false;

    public bool start = false; //if start = true, its already open from the start and shouldn't do a sound at the begining
    //should set to false after being disabled!


    public AudioSource QuestSound;
    public AudioClip closeTap, openTab;

    void OnEnable()
    {
        if(Questb == true)
        {
            QuestSound.clip = openTab;
            QuestSound.Play();
        }

        if ((Questa == true) && (start == false))
        {
            QuestSound.clip = closeTap;
            QuestSound.Play();
        }

    }

    void OnDisable()
    {
        if ((Questa == true) && (start == true))
        {
            start = false;
        }

    }
}
