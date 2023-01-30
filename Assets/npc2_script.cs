using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc2_script : MonoBehaviour
{
    public float speed = 3;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
}
