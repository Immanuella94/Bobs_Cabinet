using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shirt_Script : MonoBehaviour
{
    public bool buy_Cloths = false;

    public bool SetPos = false;


    //which Position is this shirt on?
    public bool S_P1 = false;
    public bool S_P2 = false;
    public bool S_P3 = false;
    public bool S_P4 = false;
    public bool S_P5 = false;
    public bool S_P6 = false;
    public bool S_P7 = false;
    public bool S_P8 = false;
    public bool S_P9 = false;
    public bool S_P10 = false;
    public bool S_P11 = false;

    void Update()
    {
        if(buy_Cloths == true)
        {
            //destroy self
            Destroy(this.gameObject);

        }

        if (Input.GetKey("k"))
        {
            //destroy self
            Destroy(this.gameObject);
        }
    }


}
