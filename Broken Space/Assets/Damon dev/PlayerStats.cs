using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    PlayerUI playerUI;
    void Start()
    {
        playerUI = GetComponent<PlayerUI> ();



        maxHealth = 1000;
        currHealth = maxHealth;

        SetStats();
    }

    public override void Die()
    {
        Debug.Log("You ded bro");
    }

    void SetStats()
    {
        playerUI.healthAmount.text = currHealth.ToString ();
    }

    public override void CheckHealth()
    {
        base.CheckHealth();
        SetStats();
    }

}
