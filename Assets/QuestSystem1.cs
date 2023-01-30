using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuestSystem : MonoBehaviour
{
    public GameObject scullEmpty1;
    public GameObject scullEmpty2;
    public GameObject scullEmpty3;
    public GameObject scullEmpty4;


    bool currentlyClosed1 = true;
    bool currentlyClosed2 = true;
    bool currentlyClosed3 = true;

    public GameObject Counter0;
    public GameObject Counter1;
    public GameObject Counter2;
    public GameObject Counter3;
    public GameObject Counter4;


    public int _Reputation = 5;

    public GameObject shirtOn;
    public GameObject shirtOn2;

    bool hasShirtNormal = false;

    Quaternion NintyRotation = Quaternion.Euler(0f, 90f, 0f);
    Quaternion NormalRotation = Quaternion.Euler(0f, 0f, 0f);

    public GameObject cross1;
    public GameObject cross2;
    public GameObject cross3;
    public GameObject cross4;
    public GameObject cross5;
    public GameObject cross6;

    public GameObject Paint1;
    public GameObject Paint2;
    public GameObject Paint3;
    public GameObject Paint4;
    public GameObject Paint5;
    public GameObject Paint6;

    public GameObject _ClosetObj_Normal;
    public GameObject _ClosetObj_Q1;
    public GameObject _ClosetObj_Q2;
    public GameObject _ClosetObj_Q3;
    public GameObject _ClosetObj;//empty

    public GameObject _ClosetObj_Normal_90;
    public GameObject _ClosetObj_Q1_90;
    public GameObject _ClosetObj_Q2_90;
    public GameObject _ClosetObj_Q3_90;
    public GameObject _ClosetObj_90;//empty

    public GameObject _ClosetObj_NormalMINI;
    public GameObject _ClosetObj_Q1MINI;
    public GameObject _ClosetObj_Q2MINI;
    public GameObject _ClosetObj_Q3MINI;
    public GameObject _ClosetObjMINI;//empty

    Vector3 spawnPosQ2;
    Vector3 currentPosSlot;

    Shirt_PlayerItem ShirtItemPlayerScr;
    [SerializeField] GameObject Q2_Obj;

    public GameObject targetQ1;
    public GameObject targetQ2;
    public GameObject targetQ3;

    //The Quest posts second image
    public GameObject targetQ1_b;
    public GameObject targetQ2_b;
    public GameObject targetQ3_b;

    public GameObject normalObj;
    public GameObject Ouest1_Obj;
    public GameObject Ouest2_Obj;
    public GameObject Ouest3_Obj;

    public GameObject normalObjVERTICALLY;
    public GameObject Ouest1_ObjVERTICALLY;
    public GameObject Ouest2_ObjVERTICALLY;
    public GameObject Ouest3_ObjVERTICALLY;

    public GameObject normalObj_Slot;
    public GameObject normalObj_SlotVERTICALLY;

    //checks if you have done current quest and if they are false, the specific quest gets deleted!
    public bool ACTIVEQuest1 = true;
    public bool ACTIVEQuest2 = true;
    public bool ACTIVEQuest3 = true;

    //which item is currently on you?
    public bool NormalItem = false;
    public bool Quest1 = false;
    public bool Quest2 = false;
    public bool Quest3 = false;

    public bool HasShirt = false;

    bool onBoard1 = false;
    bool onBoard2 = false;
    bool onBoard3 = false;


    void Start()
    {
        targetQ1.SetActive(true);
        targetQ2.SetActive(true);
        targetQ3.SetActive(true);
    }

    void Awake()
    {
        ShirtItemPlayerScr = Q2_Obj.GetComponent<Shirt_PlayerItem>();
    }

    void Update()
    {
        

        if ((HasShirt == true) && (hasShirtNormal == false))
        {
            shirtOn.SetActive(true);
            shirtOn2.SetActive(false);
        }

        if ((HasShirt == true) && (hasShirtNormal == true))
        {
            shirtOn2.SetActive(true);
            shirtOn.SetActive(false);
        }

        if (HasShirt == false)
        {
            shirtOn.SetActive(false);
            shirtOn2.SetActive(false);
        }

        //if Quest is finished, picture vanishes
        if (ACTIVEQuest1 == false)
        {
            targetQ1.SetActive(false);
            //take one number away from shirt
            if(currentlyClosed1 == true)
            {
                CheckGameObject();
                currentlyClosed1 = false;
            }
            
        }

        if (ACTIVEQuest2 == false)
        {
            targetQ2.SetActive(false);
            //take one number away from shirt
            if (currentlyClosed2 == true)
            {
                CheckGameObject();
                currentlyClosed2 = false;
            }

        }

        if (ACTIVEQuest3 == false)
        {
            targetQ3.SetActive(false);
            if (currentlyClosed3 == true)
            {
                CheckGameObject();
                currentlyClosed3 = false;
            }
        }


        //If numbers 1 2 and 3 are pressed open and close the tab
        

        if (((onBoard2 == true) && (Input.GetKeyDown("4"))) && ACTIVEQuest2 == true)
        {
            targetQ2.SetActive(true);
            targetQ2_b.SetActive(false);
            onBoard2 = false;
        }

        if (((onBoard3 == true) && (Input.GetKeyDown("4"))) && ACTIVEQuest3 == true)
        {
            targetQ3.SetActive(true);
            targetQ3_b.SetActive(false);
            onBoard3 = false;
        }

        if (((onBoard1 == true) && (Input.GetKeyDown("4"))) && ACTIVEQuest1 == true)
        {
            targetQ1.SetActive(true);
            targetQ1_b.SetActive(false);
            onBoard1 = false;
        }


        if (((Input.GetKeyDown("1")) && ACTIVEQuest1 == true) && (onBoard1 == false))
        {
            targetQ1.SetActive(false);
            targetQ1_b.SetActive(true);

            targetQ2.SetActive(true);
            targetQ2_b.SetActive(false);

            targetQ3.SetActive(true);
            targetQ3_b.SetActive(false);
            onBoard1 = true;
            onBoard2 = false;
            onBoard3 = false;
        }

        if (((Input.GetKeyDown("2")) &&ACTIVEQuest2 == true) && (onBoard2 == false))
        {
            targetQ2.SetActive(false);
            targetQ2_b.SetActive(true);

            targetQ1.SetActive(true);
            targetQ1_b.SetActive(false);

            targetQ3.SetActive(true);
            targetQ3_b.SetActive(false);
            onBoard2 = true;
            onBoard1 = false;
            onBoard3 = false;
        }

        if (((Input.GetKeyDown("3")) && ACTIVEQuest3 == true) && (onBoard3 == false))
        {
            targetQ3.SetActive(false);
            targetQ3_b.SetActive(true);

            targetQ2.SetActive(true);
            targetQ2_b.SetActive(false);

            targetQ1.SetActive(true);
            targetQ1_b.SetActive(false);
            onBoard3 = true;
            onBoard2 = false;
            onBoard1 = false;
        }


        //Reputation
        if (_Reputation == 6)
        {
            //close every cross unless 1
            cross1.SetActive(false);
            cross2.SetActive(false);
            cross3.SetActive(false);
            cross4.SetActive(false);
            cross5.SetActive(false);
            cross6.SetActive(true);

            Paint1.SetActive(true);
            Paint2.SetActive(true);
            Paint3.SetActive(true);
            Paint4.SetActive(true);
            Paint5.SetActive(true);
            Paint6.SetActive(true);
        }

        if (_Reputation == 5)
        {
            //close every cross unless 1
            cross1.SetActive(false);
            cross2.SetActive(false);
            cross3.SetActive(false);
            cross4.SetActive(false);
            cross5.SetActive(true);
            cross6.SetActive(false);

            Paint1.SetActive(true);
            Paint2.SetActive(true);
            Paint3.SetActive(true);
            Paint4.SetActive(true);
            Paint5.SetActive(true);
            Paint6.SetActive(false);
        }

        if (_Reputation == 4)
        {
            //close every cross unless 1
            cross1.SetActive(false);
            cross2.SetActive(false);
            cross3.SetActive(false);
            cross4.SetActive(true);
            cross5.SetActive(false);
            cross6.SetActive(false);

            Paint1.SetActive(true);
            Paint2.SetActive(true);
            Paint3.SetActive(true);
            Paint4.SetActive(true);
            Paint5.SetActive(false);
            Paint6.SetActive(false);
        }

        if (_Reputation == 3)
        {
            //close every cross unless 1
            cross1.SetActive(false);
            cross2.SetActive(false);
            cross3.SetActive(true);
            cross4.SetActive(false);
            cross5.SetActive(false);
            cross6.SetActive(false);

            Paint1.SetActive(true);
            Paint2.SetActive(true);
            Paint3.SetActive(true);
            Paint4.SetActive(false);
            Paint5.SetActive(false);
            Paint6.SetActive(false);
        }

        if (_Reputation == 2)
        {
            //close every cross unless 1
            cross1.SetActive(false);
            cross2.SetActive(true);
            cross3.SetActive(false);
            cross4.SetActive(false);
            cross5.SetActive(false);

            Paint1.SetActive(true);
            Paint2.SetActive(true);
            Paint3.SetActive(false);
            Paint4.SetActive(false);
            Paint5.SetActive(false);
            Paint6.SetActive(false);
            cross6.SetActive(false);
        }

        if (_Reputation == 1)
        {
            //close every cross unless 1
            cross1.SetActive(true);
            cross2.SetActive(false);
            cross3.SetActive(false);
            cross4.SetActive(false);
            cross5.SetActive(false);
            cross6.SetActive(false);

            Paint1.SetActive(true);
            Paint2.SetActive(true);
            Paint3.SetActive(false);
            Paint4.SetActive(false);
            Paint5.SetActive(false);
            Paint6.SetActive(false);
        }

        
        //For me to test it
        if(Input.GetKeyDown("f"))
        {
            Take_Reputation();
            Debug.Log("took reputation: " + _Reputation);
        }

        if (Input.GetKeyDown("g"))
        {
            Give_Reputation();
            Debug.Log("gave reputation: " + _Reputation);
        }

    }

    void OnCollisionStay(Collision collisionInfo)
    {

        //Check to carry shirt ITEMS FROM THE GROUND
        if ((collisionInfo.gameObject.tag == "Q1") && (HasShirt == false))//Q1 EMPTY
        {

            if ((HasShirt == false) && (Input.GetKeyDown("space")))
            {
                // add shirt to the player
                Quest1 = true;
                Destroy(collisionInfo.gameObject);
                // then make HasShirt false
                HasShirt = true;
                hasShirtNormal = false;
            }

        }

        if ((collisionInfo.gameObject.tag == "Q2") && (HasShirt == false))//Q2 EMPTY
        {

            if ((HasShirt == false) && (Input.GetKeyDown("space")))
            {
                // add shirt to the player
                Quest2 = true;
                Destroy(collisionInfo.gameObject);
                // then make HasShirt false
                HasShirt = true;
                hasShirtNormal = false;
            }

        }

        if ((collisionInfo.gameObject.tag == "Q3") && (HasShirt == false))//Q3 EMPTY
        {

            if ((HasShirt == false) && (Input.GetKeyDown("space")))
            {
                // add shirt to the player
                Quest3 = true;
                Destroy(collisionInfo.gameObject);
                // then make HasShirt false
                HasShirt = true;
                hasShirtNormal = false;
            }

        }

        if ((collisionInfo.gameObject.tag == "NormalItem") && (HasShirt == false))//NormalItem EMPTY
        {

            if ((HasShirt == false) && (Input.GetKeyDown("space")))
            {
                // add shirt to the player
                NormalItem = true;
                Destroy(collisionInfo.gameObject);
                // then make HasShirt false
                HasShirt = true;
                hasShirtNormal = true;
            }

        }


        //###############if collision with slot to hang cloths###########

        if ((collisionInfo.gameObject.tag == "Slot") && (HasShirt == true))
        {
            if (Input.GetKeyDown("space"))
            {
                if(NormalItem == true)
                {
                    NormalItem = false;
                    HasShirt = false;

                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(normalObj, currentPosSlot, transform.rotation); //rotation changing?
                    //normalObj.transform.rotation = Quaternion.Euler(0, collisionInfo.transform.rotation.eulerAngles.y, 0); doesn't work

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest1 == true)
                {
                    Quest1 = false;
                    HasShirt = false;

                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(Ouest1_Obj, currentPosSlot, transform.rotation);

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest2 == true)
                {
                    Quest2 = false;
                    HasShirt = false;

                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(Ouest2_Obj, currentPosSlot, transform.rotation);

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest3 == true)
                {
                    Quest3 = false;
                    HasShirt = false;

                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(Ouest3_Obj, currentPosSlot, transform.rotation);

                    Destroy(collisionInfo.gameObject);
                    return;
                }

            }
        }

        if ((collisionInfo.gameObject.tag == "Slot-Vertically") && (HasShirt == true))
        {
            if (Input.GetKeyDown("space"))
            {
                if (NormalItem == true)
                {
                    NormalItem = false;
                    HasShirt = false;

                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(normalObjVERTICALLY, currentPosSlot, NintyRotation); //rotation changing?
                                                                                     //normalObj.transform.rotation = Quaternion.Euler(0, collisionInfo.transform.rotation.eulerAngles.y, 0); doesn't work

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest1 == true)
                {
                    Quest1 = false;
                    HasShirt = false;

                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(Ouest1_ObjVERTICALLY, currentPosSlot, NintyRotation);

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest2 == true)
                {
                    Quest2 = false;
                    HasShirt = false;

                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(Ouest2_ObjVERTICALLY, currentPosSlot, NintyRotation);

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest3 == true)
                {
                    Quest3 = false;
                    HasShirt = false;

                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(Ouest3_ObjVERTICALLY, currentPosSlot, NintyRotation);

                    Destroy(collisionInfo.gameObject);
                    return;
                }

            }
        }

        //######take cloths from slot###################################

        if ((collisionInfo.gameObject.tag == "Shirt_Rag_Normal") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                NormalItem = true;

                //spawn item
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(normalObj_Slot, currentPosSlot, transform.rotation); //rotation changing?
                hasShirtNormal = true;
                Destroy(collisionInfo.gameObject);
                return;
            }
        }

        if ((collisionInfo.gameObject.tag == "Shirt_Rag_Q1") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest1 = true;

                //spawn item
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(normalObj_Slot, currentPosSlot, transform.rotation); //rotation changing?
                hasShirtNormal = false;
                Destroy(collisionInfo.gameObject);
                return;
            }
        }

        if ((collisionInfo.gameObject.tag == "Shirt_Rag_Q2") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest2 = true;

                //spawn item
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(normalObj_Slot, currentPosSlot, transform.rotation); //rotation changing?
                hasShirtNormal = false;
                Destroy(collisionInfo.gameObject);
                return;
            }
        }

        if ((collisionInfo.gameObject.tag == "Shirt_Rag_Q3") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest3 = true;
                hasShirtNormal = false;
                //spawn item
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(normalObj_Slot, currentPosSlot, transform.rotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;
            }
        }



        if ((collisionInfo.gameObject.tag == "Shirt_Rag_Normal_Vertically") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                NormalItem = true;
                hasShirtNormal = true;
                //spawn item
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(normalObj_SlotVERTICALLY, currentPosSlot, NormalRotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;
            }
        }

        if ((collisionInfo.gameObject.tag == "Shirt_Rag_Q1_Vertically") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest1 = true;
                hasShirtNormal = false;
                //spawn item
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(normalObj_SlotVERTICALLY, currentPosSlot, NormalRotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;
            }
        }

        if ((collisionInfo.gameObject.tag == "Shirt_Rag_Q2_Vertically") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest2 = true;
                hasShirtNormal = false;
                //spawn item
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(normalObj_SlotVERTICALLY, currentPosSlot, NormalRotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;
            }
        }

        if ((collisionInfo.gameObject.tag == "Shirt_Rag_Q3_Vertically") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest3 = true;
                hasShirtNormal = false;
                //spawn item
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(normalObj_SlotVERTICALLY, currentPosSlot, NormalRotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;
            }
        }




        //######_CLOSET HIDING SHIRTS! (only one) _###################################




        //if closet empty and inv full
        if ((collisionInfo.gameObject.tag == "_Closet") && (HasShirt == true))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = false;

                if (NormalItem == true)
                {
                    NormalItem = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_Normal, currentPosSlot, transform.rotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest1 == true)
                {
                    Quest1 = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_Q1, currentPosSlot, transform.rotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest2 == true)
                {
                    Quest2 = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_Q2, currentPosSlot, transform.rotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest3 == true)
                {
                    Quest3 = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_Q3, currentPosSlot, transform.rotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }
            }

        }


        //if closet empty and inv full VERTICALLY
        if ((collisionInfo.gameObject.tag == "_ClosetVertically") && (HasShirt == true))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = false;

                if (NormalItem == true)
                {
                    NormalItem = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_Normal_90, currentPosSlot, NintyRotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest1 == true)
                {
                    Quest1 = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_Q1_90, currentPosSlot, NintyRotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest2 == true)
                {
                    Quest2 = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_Q2_90, currentPosSlot, NintyRotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest3 == true)
                {
                    Quest3 = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_Q3_90, currentPosSlot, NintyRotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }
            }

        }


        if ((collisionInfo.gameObject.tag == "_ClosetMINI") && (HasShirt == true))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = false;

                if (NormalItem == true)
                {
                    NormalItem = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_NormalMINI, currentPosSlot, transform.rotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest1 == true)
                {
                    Quest1 = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_Q1MINI, currentPosSlot, transform.rotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest2 == true)
                {
                    Quest2 = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_Q2MINI, currentPosSlot, transform.rotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }

                if (Quest3 == true)
                {
                    Quest3 = false;
                    currentPosSlot = collisionInfo.transform.position;
                    Instantiate(_ClosetObj_Q3MINI, currentPosSlot, transform.rotation); //rotation changing?

                    Destroy(collisionInfo.gameObject);
                    return;
                }
            }

        }



        //if closet full and inv empty
        if ((collisionInfo.gameObject.tag == "_Closet_Normal") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                NormalItem = true;
                hasShirtNormal = true;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObj, currentPosSlot, transform.rotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;
                
            }
        }

        if ((collisionInfo.gameObject.tag == "_Closet_Q1") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest1 = true;
                hasShirtNormal = false;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObj, currentPosSlot, transform.rotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;

            }
        }

        if ((collisionInfo.gameObject.tag == "_Closet_Q2") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest2 = true;
                hasShirtNormal = false;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObj, currentPosSlot, transform.rotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;

            }
        }

        if ((collisionInfo.gameObject.tag == "_Closet_Q3") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest3 = true;
                hasShirtNormal = false;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObj, currentPosSlot, transform.rotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;

            }
        }



        //NIGHTY DEGREES

        //if closet full and inv empty 90
        if ((collisionInfo.gameObject.tag == "_Closet_Normal-90") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                NormalItem = true;
                hasShirtNormal = true;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObj_90, currentPosSlot, NintyRotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;

            }
        }

        if ((collisionInfo.gameObject.tag == "_Closet_Q1-90") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest1 = true;
                hasShirtNormal = false;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObj_90, currentPosSlot, NintyRotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;

            }
        }

        if ((collisionInfo.gameObject.tag == "_Closet_Q2-90") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest2 = true;
                hasShirtNormal = false;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObj_90, currentPosSlot, NintyRotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;

            }
        }

        if ((collisionInfo.gameObject.tag == "_Closet_Q3-90") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest3 = true;
                hasShirtNormal = false;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObj_90, currentPosSlot, NintyRotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;

            }
        }



        //Closet full inv Empty MINI
        if ((collisionInfo.gameObject.tag == "_Closet_NormalMINI") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                NormalItem = true;
                hasShirtNormal = true;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObjMINI, currentPosSlot, transform.rotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;

            }
        }

        if ((collisionInfo.gameObject.tag == "_Closet_Q1MINI") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest1 = true;
                hasShirtNormal = false;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObjMINI, currentPosSlot, transform.rotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;

            }
        }

        if ((collisionInfo.gameObject.tag == "_Closet_Q2MINI") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest2 = true;
                hasShirtNormal = false;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObjMINI, currentPosSlot, transform.rotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;

            }
        }

        if ((collisionInfo.gameObject.tag == "_Closet_Q3MINI") && (HasShirt == false))
        {
            if (Input.GetKeyDown("space"))
            {
                // reduce shirt from player
                HasShirt = true;
                Quest3 = true;
                hasShirtNormal = false;
                currentPosSlot = collisionInfo.transform.position;
                Instantiate(_ClosetObjMINI, currentPosSlot, transform.rotation); //rotation changing?

                Destroy(collisionInfo.gameObject);
                return;

            }
        }




        //Quest Beendet aka finsihed
        if ((collisionInfo.gameObject.tag == "basement") && (HasShirt == true))
        {
            if (Input.GetKeyDown("space"))
            {
                if(Quest1 == true)
                {
                    //like killing animation -> stop everything and start talking animation thing
                    Quest1 = false;
                    HasShirt = false;
                    ACTIVEQuest1 = false;
                    CheckGameObject();


                }

                if (Quest2 == true)
                {
                    //here too
                    Quest2 = false;
                    HasShirt = false;
                    ACTIVEQuest2 = false;
                    CheckGameObject();
                }

                if (Quest3 == true)
                {
                    //here too
                    Quest3 = false;
                    HasShirt = false;
                    ACTIVEQuest3 = false;
                    CheckGameObject();
                }


            }
        }








    }//end of collision

    void Take_Reputation()
    {
        if (_Reputation >= 2)
        {
            _Reputation = _Reputation - 1;
        }
    }

    void Give_Reputation()
    {
        if (_Reputation <= 5)
        {
            _Reputation = _Reputation + 1;
        }
    }

    void CheckGameObject()
    {
        if (Counter2.activeSelf)
        {

            Counter3.SetActive(true);
            scullEmpty3.SetActive(false);

        }
            if (Counter1.activeSelf)
            {
                Counter2.SetActive(true);
                scullEmpty2.SetActive(false);

            }
                if (Counter0.activeSelf)
                {
                    // do something, if it is not active...
                    Counter1.SetActive(true);
                    scullEmpty1.SetActive(false);

                }
            
        


        

        

    }

}
