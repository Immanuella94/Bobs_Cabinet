using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soul_Taker_Scr : MonoBehaviour
{
    //Set existing falue = true once the npc with this value spawns

    int randomNumber;

    /// Hiar
    public bool Hair_blue = false;
    public bool Hair_brown = false;
    
    /// Cloths
    public bool Shirt_blue = false;
    public bool Shirt_red = false;

    ///Personality ##not in use for now
    // bool Karen = false;

    bool currentlyOnAQuest = false;

    void Start()
    {
        // 0 - Hair_blue, 1 - Hair_brown, 2 - Shirt_blue, 3 - Shirt_red ## just for you to know
    }


    void Update()
    {
        //set a random number between the numbers you have
        //check if the number is reffering a bool that is currently active,
        //if bool is active, set Request, if not - take a new random number
        RandomQuest();


        //check if numer belongs to a bool
        if(randomNumber == 0) //blue Hair
        {
            if(Hair_blue == true)
            {
                //Set quest to this
            }
            else if (Hair_blue == false)
            {
                currentlyOnAQuest = false;
                RandomQuest();
            }
        }
    }

    void FixedUpdate()
    {
        //set valu back to false

        /// Hiar
        Hair_blue = false;
        Hair_brown = false;

        /// Cloths
        Shirt_blue = false;
        Shirt_red = false;
    }

void RandomQuest()
    {
        //set a lever to check if your currently on a quest to start a new quest
        if(currentlyOnAQuest == false)
        {
            //if quest is set , add an image in a corner to know what to get
            randomNumber = Random.Range(0, 3);
            {

            }
            currentlyOnAQuest = true;

        }
    }

}
