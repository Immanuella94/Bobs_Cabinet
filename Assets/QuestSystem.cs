using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestSystem : MonoBehaviour
    {

    public GameObject QuestLucifer;
    public GameObject BelzeboobQuest;
    public GameObject LeviathanQuest;

        public GameObject scullEmpty1;
        public GameObject scullEmpty2;
        public GameObject scullEmpty3;
        public GameObject scullEmpty4;

       // bool currentlyClosed1 = true;
       // bool currentlyClosed2 = true;
       // bool currentlyClosed3 = true;

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

        public GameObject targetQ1; //Closed Request
        public GameObject targetQ2;
        public GameObject targetQ3;

        //The Quest posts second image
        public GameObject targetQ1_b; //OPEN REQUEST
        public GameObject targetQ2_b;
        public GameObject targetQ3_b;

        public GameObject targetQ1_c;//Open Request if NPC died  '''''''''''''''''''''''''''''''''''''''''''''''''''--------------------------00000000000000000000000000
        public GameObject targetQ2_c;
        public GameObject targetQ3_c;

        public GameObject targetQ1_d; //closed Request if npc died
        public GameObject targetQ2_d;
        public GameObject targetQ3_d;

        public GameObject targetQ1_e; //Open finished Request
        public GameObject targetQ2_e;
        public GameObject targetQ3_e;

        public GameObject targetQ1_f;//closed finished Request
        public GameObject targetQ2_f;
        public GameObject targetQ3_f;

        public bool QuestNpcDeath1; //if the npc was killed from the quest
        public bool QuestNpcDeath2;
        public bool QuestNpcDeath3;

    int currewntlyOpen = 0; //0 non open, 1 open 1, 2 open 2 etc

        public bool QuestFinished1; //if the quest is finsihed =========================================================================================
        public bool QuestFinished2;
        public bool QuestFinished3;

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

    bool PlayThisOnce1 = true;
    bool PlayThisOnce2 = true;
    bool PlayThisOnce3 = true;

    public bool HasShirt = false;

        bool onBoard1 = false;
        bool onBoard2 = false;
        bool onBoard3 = false;

   // bool QuestOnce = false; 
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

        if (Input.anyKeyDown)
        {
            QuestLucifer.SetActive(false);
            LeviathanQuest.SetActive(false);
            BelzeboobQuest.SetActive(false);

        }

        //if Quest is finished, picture vanishes
        if ((ACTIVEQuest1 == false) && (PlayThisOnce1 == true))
            {
                QuestFinished1 = true;
            QuestLucifer.SetActive(true);
            PlayThisOnce1 = false;



        }

            if ((ACTIVEQuest2 == false) && (PlayThisOnce2 == true))
        {
                 QuestFinished2 = true;
            BelzeboobQuest.SetActive(true);
            PlayThisOnce2 = false;
        }

            if ((ACTIVEQuest3 == false) && (PlayThisOnce3 == true))
        {
                QuestFinished3 = true;
            LeviathanQuest.SetActive(true);
            PlayThisOnce3 = false;
        }

            if((ACTIVEQuest1 == false) && (ACTIVEQuest2 == false) && (ACTIVEQuest3 == false))
        {
            //go to winning screen
            SceneManager.LoadScene(4);

        }

        //If numbers 1 2 and 3 are pressed open and close the tab
        QuestRequestManager();

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

            /*
            //For me to test it
            if (Input.GetKeyDown("f"))
            {
                Take_Reputation();
                Debug.Log("took reputation: " + _Reputation);
            }

            if (Input.GetKeyDown("g"))
            {
                Give_Reputation();
                Debug.Log("gave reputation: " + _Reputation);
            }*/

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
                    if (NormalItem == true)
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
                    if (Quest1 == true)
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


        void QuestRequestManager()
        {
            if (Input.GetKeyDown("4")) //set them all down
            {
                currewntlyOpen = 0;
            }

        if ((Input.GetKeyDown("1")) && (onBoard1 == false)) //OPENING REQUEST
        {
            currewntlyOpen = 1;

            if (currewntlyOpen == 1) //if one is open , open 1
            {


                if ((QuestNpcDeath1 == false) && (QuestFinished1 == false)) //normal request 1
                {
                    targetQ1.SetActive(false);
                    targetQ1_b.SetActive(true);

                    onBoard1 = true;
                }

                if ((QuestNpcDeath1 == true) && (QuestFinished1 == false)) //NPC died 1
                {
                    targetQ1_d.SetActive(false);
                    targetQ1_c.SetActive(true);

                    onBoard1 = true;
                }

                if (QuestFinished1 == true) //NPC Quest finished ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                {
                    targetQ1_f.SetActive(false);//open requesd
                    targetQ1_e.SetActive(true);//closeed requesd

                    targetQ1_d.SetActive(false);
                    targetQ1_c.SetActive(false);
                    targetQ1_b.SetActive(false);
                    targetQ1.SetActive(false);

                    onBoard1 = false;
                }
            }

        }

        if ((Input.GetKeyDown("2")) && (onBoard2 == false)) //OPENING REQUEST
        {
            currewntlyOpen = 2;

            if (currewntlyOpen == 2) //if one is open , open 1
            {


                if ((QuestNpcDeath2 == false) && (QuestFinished2 == false)) //normal request 1
                {
                    targetQ2.SetActive(false);
                    targetQ2_b.SetActive(true);

                    onBoard2 = true;
                }

                if ((QuestNpcDeath2 == true) && (QuestFinished2 == false)) //NPC died 1
                {
                    targetQ2_d.SetActive(false);
                    targetQ2_c.SetActive(true);

                    onBoard2 = true;
                }

                if (QuestFinished2 == true) //NPC Quest finished ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                {
                    targetQ2_f.SetActive(false);//open requesd
                    targetQ2_e.SetActive(true);//closeed requesd

                    targetQ2_d.SetActive(false);
                    targetQ2_c.SetActive(false);
                    targetQ2_b.SetActive(false);
                    targetQ2.SetActive(false);

                    onBoard2 = false;
                }
            }

        }

        if ((Input.GetKeyDown("3")) && (onBoard3 == false)) //OPENING REQUEST
            {
                currewntlyOpen = 3;

                if (currewntlyOpen == 3) //if one is open , open 1
                {


                    if ((QuestNpcDeath3 == false) && (QuestFinished3 == false)) //normal request 1
                    {
                        targetQ3.SetActive(false);
                        targetQ3_b.SetActive(true);

                        onBoard3 = true;
                    }

                    if ((QuestNpcDeath3 == true) && (QuestFinished3 == false)) //NPC died 1
                    {
                        targetQ3_d.SetActive(false);
                        targetQ3_c.SetActive(true);

                        onBoard3 = true;
                    }

                    if (QuestFinished3 == true) //NPC Quest finished ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    {
                        targetQ3_f.SetActive(false);//open requesd
                        targetQ3_e.SetActive(true);//closeed requesd

                        targetQ3_d.SetActive(false);
                        targetQ3_c.SetActive(false);
                        targetQ3_b.SetActive(false);
                        targetQ3.SetActive(false);

                    onBoard3 = false;
                    }
                }
        
            }

        //close request
        
        if (currewntlyOpen != 1) //if one is not open close 1
        {
            if ((QuestNpcDeath1 == false) && (QuestFinished1 == false)) //normal request 1
            {
                targetQ1_b.SetActive(false);
                targetQ1.SetActive(true);

                onBoard1 = false;
            }

            if ((QuestNpcDeath1 == true) && (QuestFinished1 == false)) //NPC died 1
            {
                targetQ1_c.SetActive(false);
                targetQ1_d.SetActive(true);

                targetQ1_b.SetActive(false);
                targetQ1.SetActive(false);

                onBoard1 = false;
            }

            if (QuestFinished1 == true) //NPC Quest finished //
            {
                targetQ1_e.SetActive(false);
                targetQ1_f.SetActive(true);

                targetQ1_d.SetActive(false);
                targetQ1_c.SetActive(false);
                targetQ1_b.SetActive(false);
                targetQ1.SetActive(false);

                onBoard1 = false;
            }


        }

        if (currewntlyOpen != 2) //if one is not open close 1
        {
            if ((QuestNpcDeath2 == false) && (QuestFinished2 == false)) //normal request 1
            {
                targetQ2_b.SetActive(false);
                targetQ2.SetActive(true);

                onBoard2 = false;
            }

            if ((QuestNpcDeath2 == true) && (QuestFinished2 == false)) //NPC died 1
            {
                targetQ2_c.SetActive(false);
                targetQ2_d.SetActive(true);

                targetQ2_b.SetActive(false);
                targetQ2.SetActive(false);

                onBoard2 = false;
            }

            if (QuestFinished2 == true) //NPC Quest finished //
            {
                targetQ2_e.SetActive(false);
                targetQ2_f.SetActive(true);

                targetQ2_d.SetActive(false);
                targetQ2_c.SetActive(false);
                targetQ2_b.SetActive(false);
                targetQ2.SetActive(false);

                onBoard2 = false;
            }


        }


        if (currewntlyOpen != 3) //if one is not open close 1
            {
                if ((QuestNpcDeath3 == false) && (QuestFinished3 == false)) //normal request 1
                {
                    targetQ3_b.SetActive(false);
                    targetQ3.SetActive(true);

                    onBoard3 = false;
                }

                if ((QuestNpcDeath3 == true) && (QuestFinished3 == false)) //NPC died 1
                {
                    targetQ3_c.SetActive(false);
                    targetQ3_d.SetActive(true);

                    targetQ3_b.SetActive(false);
                    targetQ3.SetActive(false);

                onBoard3 = false;
                }

                if (QuestFinished3 == true) //NPC Quest finished //
                {
                    targetQ3_e.SetActive(false);
                    targetQ3_f.SetActive(true);

                    targetQ3_d.SetActive(false);
                    targetQ3_c.SetActive(false);
                    targetQ3_b.SetActive(false);
                    targetQ3.SetActive(false);

                onBoard3 = false;
                }
            

        }









    }



}


