using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soul_id_Script : MonoBehaviour
{
    public bool changed = false;

    public bool Hair_blue = false;
    public bool Hair_brown = false;

    public bool Shirt_blue = false;
    public bool Shirt_red = false;

    void Start()
    {
        Debug.Log("Hair is blue? " + Hair_blue);
        Debug.Log("Hair is brown? " + Hair_brown);
        Debug.Log("Shirt is blue? " + Shirt_blue);
        Debug.Log("Shirt is red? " + Shirt_red);
    }

    void Update()
    {
        
    }
}
