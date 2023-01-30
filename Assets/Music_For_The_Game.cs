using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_For_The_Game : MonoBehaviour
{
    public bool InGame = false;
    public bool InMenu = false;
    public bool InScene = false;

    public AudioSource MusicMaker;
    public AudioClip inGameMusic, MenuMusic, SceneMusic; //etc..

    void Start()
    {
        if(InGame == true)
        {
            MusicMaker.clip = inGameMusic;
            MusicMaker.Play();
        }

        if (InMenu == true)
        {
            MusicMaker.clip = MenuMusic;
            MusicMaker.Play();
        }

        if (InScene == true)
        {
            MusicMaker.clip = SceneMusic;
            MusicMaker.Play();
        }
    }

}
