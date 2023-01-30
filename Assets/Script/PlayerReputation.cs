using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReputation : MonoBehaviour
{

    public int maxHealth = 100;
    public int CurrentHealth = 0;

    public RepBarScr healthbar;

    void Start()
    {
        CurrentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        //if rep down take damage aka if npc leaves

        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakesDamage(10);
        }

        if(CurrentHealth <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }

    void TakesDamage(int damage)
    {
        CurrentHealth = CurrentHealth - damage;

        healthbar.SetHealth(CurrentHealth);
    }
}
