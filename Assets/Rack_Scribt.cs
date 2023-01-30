using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rack_Scribt : MonoBehaviour
{
    public Shirt_Script ShirtScr;

    public GameObject objectToSpawn;//shirt

    public bool P1 = false; //no cloths on there
    public bool P2 = false; //no cloths on there
    public bool P3 = false; //no cloths on there
    public bool P4 = false; //no cloths on there
    public bool P5 = false; //no cloths on there
    public bool P6 = false; //no cloths on there
    public bool P7 = false; //no cloths on there
    public bool P8 = false; //no cloths on there
    public bool P9 = false; //no cloths on there
    public bool P10 = false; //no cloths on there
    public bool P11 = false; //no cloths on there

    bool ShirtCreating1 = false; //to only create on shirt at a time
    bool ShirtCreating2 = false;
    bool ShirtCreating3 = false;
    bool ShirtCreating4 = false;
    bool ShirtCreating5 = false;
    bool ShirtCreating6 = false;
    bool ShirtCreating7 = false;
    bool ShirtCreating8 = false;
    bool ShirtCreating9 = false;
    bool ShirtCreating10 = false;
    bool ShirtCreating11 = false;

    public Transform Trans_P1;//takes the place holders position
    public Transform Trans_P2;
    public Transform Trans_P3;
    public Transform Trans_P4;
    public Transform Trans_P5;
    public Transform Trans_P6;
    public Transform Trans_P7;
    public Transform Trans_P8;
    public Transform Trans_P9;
    public Transform Trans_P10;
    public Transform Trans_P11;



    //secont lever!
    public bool LP1 = false; 
    public bool LP2 = false;
    public bool LP3 = false; 
    public bool LP4 = false; 
    public bool LP5 = false; 
    public bool LP6 = false; 
    public bool LP7 = false; 
    public bool LP8 = false; 
    public bool LP9 = false; 
    public bool LP10 = false; 
    public bool LP11 = false;

    //for the quest later on, marks taken slots, that were taken from the designed level!
    //why did i make 11 slots?? i hatemyself! ;-; this is sooo many!!
    public bool TP1 = false;
    public bool TP2 = false;
    public bool TP3 = false;
    public bool TP4 = false;
    public bool TP5 = false;
    public bool TP6 = false;
    public bool TP7 = false;
    public bool TP8 = false;
    public bool TP9 = false;
    public bool TP10 = false;
    public bool TP11 = false;

    //VERY IMPORTANT FOR THE QUEST - if you add a bad corps shirt - let it change the TP slot to true, so it wont reset its slot to free!
    //the P slots count if somthing is hanging on this position, the TP says that the P with the same number can't be reseted! if TP1 = true, dann hängt etwas auf Slot 1 (aka P1) was entweder
    //vom Game start da schon hang oder ein Nicht Questoptionaler tod war! Der jetzt den slot fülled un dem Player den platz versperrt!

    void Start()
    {
        // mark all the slots already taken which are already taken!
        MarkChecker();
    }

    void Update()
    {

        P_Pos_Updater();

        P_Shirt_Destroyer();

        UnChecker();



    }

    void OnCollisionStay(Collision collisionInfo)
    {

        if (collisionInfo.gameObject.tag == "Player")
        {
            if (Input.GetKey("space"))
            {
                //another if state to check if the player has one cloth on them
                //then check if the PlaceHolder spots P1 to P11 are free or not
                if (P1 == false) //check
                {
                    P1 = true; //set
                    ShirtCreating1 = true;
                }
                else if (P1 == true) //then
                {
                    if (P2 == false) //check
                    {
                        P2 = true; //set
                        ShirtCreating2 = true;
                    }
                    else if (P2 == true)
                    {
                        if (P3 == false)
                        {
                            P3 = true;
                            ShirtCreating3 = true;
                        }
                        else if (P3 == true)
                        {
                            if (P4 == false)
                            {
                                P4 = true;
                                ShirtCreating4 = true;
                            }
                            else if (P4 == true)
                            {
                                if (P5 == false)
                                {
                                    P5 = true;
                                    ShirtCreating5 = true;
                                }
                                else if (P5 == true)
                                {
                                    if (P6 == false)
                                    {
                                        P6 = true;
                                        ShirtCreating6 = true;
                                    }
                                    else if (P6 == true)
                                    {
                                        if (P7 == false)
                                        {
                                            P7 = true;
                                            ShirtCreating7 = true;

                                        }
                                        else if (P7 == true)
                                        {
                                            if (P8 == false)
                                            {
                                                P8 = true;
                                                ShirtCreating8 = true;
                                            }
                                            else if (P8 == true)
                                            {
                                                if (P9 == false)
                                                {
                                                    P9 = true;
                                                    ShirtCreating9 = true;
                                                }
                                                else if (P9 == true)
                                                {
                                                    if (P10 == false)
                                                    {
                                                        P10 = true;
                                                        ShirtCreating10 = true;
                                                    }
                                                    else if (P10 == true)
                                                    {
                                                        if (P11 == false)
                                                        {
                                                            P11 = true;
                                                            ShirtCreating11 = true;
                                                        }
                                                        else if (P11 == true)
                                                        {
                                                            Debug.Log("Sorry, Bob! The rack seems to be full already!");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

            }
        }
    }

    void P_Pos_Updater()
    {
        //bool ThisSetPos = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().SetPos;
        ShirtScr = objectToSpawn.GetComponent<Shirt_Script>();

        if ((P1 == true) && (ShirtCreating1 == true))
        {
            //spawn shirt at P1 pos
            Instantiate(objectToSpawn, Trans_P1.position, transform.rotation);
            ShirtCreating1 = false;

            if((ShirtScr.SetPos == false) && (LP1 == false))//this shirt already has set one pos
            {
                ShirtScr.S_P1 = true;
                ShirtScr.SetPos = true;
                LP1 = true;
            }

        }

        if ((P2 == true) && (ShirtCreating2 == true))
        {
            //spawn shirt at P1 pos
            Instantiate(objectToSpawn, Trans_P2.position, transform.rotation);
            ShirtCreating2 = false;

            /*
            if (ThisSetPos == false)//this shirt already has set one pos
            {
                ShirtScr.S_P2 = true;
                ShirtScr.SetPos = true;
            }*/
        }

        if ((P3 == true) && (ShirtCreating3 == true))
        {
            //spawn shirt at P1 pos
            Instantiate(objectToSpawn, Trans_P3.position, transform.rotation);
            ShirtCreating3 = false;

            /*
            if (ThisSetPos == false)//this shirt already has set one pos
            {
                ShirtScr.S_P3 = true;
                ShirtScr.SetPos = true;
            }*/
        }

        if ((P4 == true) && (ShirtCreating4 == true))
        {
            //spawn shirt at P1 pos
            Instantiate(objectToSpawn, Trans_P4.position, transform.rotation);
            ShirtCreating4 = false;

            /*
            if (ThisSetPos == false)//this shirt already has set one pos
            {
                ShirtScr.S_P4 = true;
                ShirtScr.SetPos = true;
            }*/
        }

        if ((P5 == true) && (ShirtCreating5 == true))
        {
            //spawn shirt at P1 pos
            Instantiate(objectToSpawn, Trans_P5.position, transform.rotation);
            ShirtCreating5 = false;

            /*
            if (ThisSetPos == false)//this shirt already has set one pos
            {
                ShirtScr.S_P5 = true;
                ShirtScr.SetPos = true;
            }*/
        }

        if ((P6 == true) && (ShirtCreating6 == true))
        {
            //spawn shirt at P1 pos
            Instantiate(objectToSpawn, Trans_P6.position, transform.rotation);
            ShirtCreating6 = false;

            /*
            if (ThisSetPos == false)//this shirt already has set one pos
            {
                ShirtScr.S_P6 = true;
                ShirtScr.SetPos = true;
            }*/
        }

        if ((P7 == true) && (ShirtCreating7 == true))
        {
            //spawn shirt at P1 pos
            Instantiate(objectToSpawn, Trans_P7.position, transform.rotation);
            ShirtCreating7 = false;

            /*
            if (ThisSetPos == false)//this shirt already has set one pos
            {
                ShirtScr.S_P7 = true;
                ShirtScr.SetPos = true;
            }*/
        }

        if ((P8 == true) && (ShirtCreating8 == true))
        {
            //spawn shirt at P1 pos
            Instantiate(objectToSpawn, Trans_P8.position, transform.rotation);
            ShirtCreating8 = false;

            /*
            if (ThisSetPos == false)//this shirt already has set one pos
            {
                ShirtScr.S_P8 = true;
                ShirtScr.SetPos = true;
            }*/
        }

        if ((P9 == true) && (ShirtCreating9 == true))
        {
            //spawn shirt at P1 pos
            Instantiate(objectToSpawn, Trans_P9.position, transform.rotation);
            ShirtCreating9 = false;

            /*
            if (ThisSetPos == false)//this shirt already has set one pos
            {
                ShirtScr.S_P9 = true;
                ShirtScr.SetPos = true;
            }*/
        }

        if ((P10 == true) && (ShirtCreating10 == true))
        {
            //spawn shirt at P1 pos
            Instantiate(objectToSpawn, Trans_P10.position, transform.rotation);
            ShirtCreating10 = false;

            /*
            if (ThisSetPos == false)//this shirt already has set one pos
            {
                ShirtScr.S_P10 = true;
                ShirtScr.SetPos = true;
            }*/
        }

        if ((P11 == true) && (ShirtCreating11 == true))
        {
            //spawn shirt at P1 pos
            Instantiate(objectToSpawn, Trans_P11.position, transform.rotation);
            ShirtCreating11 = false;

            /*
            if (ThisSetPos == false)//this shirt already has set one pos
            {
                ShirtScr.S_P11 = true;
                ShirtScr.SetPos = true;
            }*/
        }
    }

    void P_Shirt_Destroyer()
    {
        /* <--THIS

        bool S_P1 = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().S_P1;
        bool S_P2 = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().S_P2;
        bool S_P3 = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().S_P3;
        bool S_P4 = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().S_P4;
        bool S_P5 = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().S_P5;
        bool S_P6 = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().S_P6;
        bool S_P7 = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().S_P7;
        bool S_P8 = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().S_P8;
        bool S_P9 = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().S_P9;
        bool S_P10 = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().S_P10;
        bool S_P11 = GameObject.FindGameObjectWithTag("Shirt").GetComponent<Shirt_Script>().S_P11;

        //first call every shirt with this tag Shirt
        GameObject shirt_obj = GameObject.FindGameObjectWithTag("Shirt");
        ShirtScr = shirt_obj.GetComponent<Shirt_Script>();

        //destroy shirt at pos
        if ((S_P1 == true) && (P1 == false))
        {
            ShirtScr.buy_Cloths = true;
        }

        if ((S_P2 == true) && (P2 == false))
        {
            ShirtScr.buy_Cloths = true;
        }

        if ((S_P3 == true) && (P3 == false))
        {
            ShirtScr.buy_Cloths = true;
        }

        if ((S_P4 == true) && (P4 == false))
        {
            ShirtScr.buy_Cloths = true;
        }

        if ((S_P5 == true) && (P5 == false))
        {
            ShirtScr.buy_Cloths = true;
        }

        if ((S_P6 == true) && (P6 == false))
        {
            ShirtScr.buy_Cloths = true;
        }

        if ((S_P7 == true) && (P7 == false))
        {
            ShirtScr.buy_Cloths = true;
        }

        if ((S_P8 == true) && (P8 == false))
        {
            ShirtScr.buy_Cloths = true;
        }

        if ((S_P9 == true) && (P9 == false))
        {
            ShirtScr.buy_Cloths = true;
        }

        if ((S_P10 == true) && (P10 == false))
        {
            ShirtScr.buy_Cloths = true;
        }

        if ((S_P11 == true) && (P11 == false))
        {
            ShirtScr.buy_Cloths = true;
        } this -> */

    }

    void MarkChecker()
    {
        
        if (P1 == true)
        {
           TP1 = true;
        }

        if (P2 == true)
        {
           TP2 = true;
        }

        if (P3 == true)
        {
           TP3 = true;
        }

        if (P4 == true)
        {
           TP4 = true;
        }

        if (P5 == true)
        {
           TP5 = true;
        }
 
        if (P6 == true)
        {
           TP6 = true;
        }

        if (P7 == true)
        {
           TP7 = true;
        }

        if (P8 == true)
        {
           TP8 = true;
        }

        if (P9 == true)
        {
           TP9 = true;         
        }

        if (P10 == true)
        {
           TP10 = true;
        }

        if (P11 == true)
        {
           TP11 = true;
        }
        
    }

    void UnChecker()
    {
        if (Input.GetKey("k"))
        {
            if (TP1 == false)
            {
                P1 = false;
            }

            if (TP2 == false)
            {
                P2 = false;
            }

            if (TP3 == false)
            {
                P3 = false;
            }

            if (TP4 == false)
            {
                P4 = false;
            }

            if (TP5 == false)
            {
                P5 = false;
            }

            if (TP6 == false)
            {
                P6 = false;
            }

            if (TP7 == false)
            {
                P7 = false;
            }

            if (TP8 == false)
            {
                P8 = false;
            }

            if (TP9 == false)
            {
                P9 = false;
            }

            if (TP10 == false)
            {
                P10 = false;
            }

            if (TP11 == false)
            {
                P11 = false;
            }
        }

    }

}
