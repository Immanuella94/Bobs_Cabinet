using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repbarGO : MonoBehaviour
{
    public GameObject TheOneThatNeedsTogetOn;

    void OnDisable()
    {


        TheOneThatNeedsTogetOn.SetActive(true);

    }
}
