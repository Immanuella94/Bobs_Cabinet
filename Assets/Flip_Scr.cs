using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip_Scr : MonoBehaviour
{
    public SpriteRenderer spi;

    void Start()
    {

        spi = GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (Input.GetKey("a"))
        {
            //flip or was it b? it will flpi twice if not set a to non
            spi.flipX = true;
        }
    }
}
