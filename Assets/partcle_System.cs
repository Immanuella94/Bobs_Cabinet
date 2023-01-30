using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partcle_System : MonoBehaviour
{
    //if collision with clossed types or shirt types - then make the sculls and destroy self,
    //other wsie in the scull thing, if collision with slot ot closetslot then make sparcle effect :D

    public GameObject pinkScullObj;
    public GameObject greenScullObj;

    void OnCollisionStay(Collision collisionInfo)
    {

        //Check to carry shirt ITEMS FROM THE GROUND

        //normal item
        if (collisionInfo.gameObject.tag == "Shirt_Rag_Normal")
        {
            Instantiate(pinkScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "Shirt_Rag_Normal_Vertically")
        {
            Instantiate(pinkScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        //quest Item
        if (collisionInfo.gameObject.tag == "Shirt_Rag_Q1")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "Shirt_Rag_Q2")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "Shirt_Rag_Q3")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        //vertically quest items
        if (collisionInfo.gameObject.tag == "Shirt_Rag_Q1_Vertically")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "Shirt_Rag_Q2_Vertically")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "Shirt_Rag_Q3_Vertically")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }



        ////closet
        
        //mini
        if (collisionInfo.gameObject.tag == "_Closet_NormalMINI")
        {
            Instantiate(pinkScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_Closet_Q1MINI")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_Closet_Q2MINI")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_Closet_Q3MINI")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        //90
        if (collisionInfo.gameObject.tag == "_Closet_Normal-90")
        {
            Instantiate(pinkScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_Closet_Q1-90")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_Closet_Q2-90")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_Closet_Q3-90")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        //Normal
        if (collisionInfo.gameObject.tag == "_Closet_Normal")
        {
            Instantiate(pinkScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_Closet_Q1")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_Closet_Q2")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (collisionInfo.gameObject.tag == "_Closet_Q3")
        {
            Instantiate(greenScullObj, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }


    }






}
