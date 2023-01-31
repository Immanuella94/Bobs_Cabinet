using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_KillingAnimation : MonoBehaviour
{
    //maybe have it always open then span it at pos of camera (canvas cam) and then back to old position to hide?
    public GameObject _killingB;
    public GameObject _killingG;
    public bool Boy = false;
    public bool Girl = true;
    public bool _Start = false;

    void Start()
    {
        _killingB.SetActive(false);
        _killingG.SetActive(false);
    }

    void Update()
    {
        if(_Start == false)
        {
            _killingB.SetActive(false);
            _killingG.SetActive(false);
        }


        if((_Start == true) && (Boy == true))
        {
            _killingB.SetActive(true);
            StartCoroutine(waiter());
        }

        if ((_Start == true) && (Girl == true))
        {
            _killingG.SetActive(true);
            StartCoroutine(waiter());
        }

    }


    void OnCollisionStay(Collision collisionInfo)
    {
        if ((collisionInfo.gameObject.tag == "NPC") && Input.GetKeyDown(KeyCode.Q))
        {
            _Start = true;

        }
    }

    IEnumerator waiter()
    {

        //Wait for 2 seconds
        yield return new WaitForSecondsRealtime(1.5f);
        _Start = false;

    }


    //use this after the animation is finished transform.position = spawnPos;







}
