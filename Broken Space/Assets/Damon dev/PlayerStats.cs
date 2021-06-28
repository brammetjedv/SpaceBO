using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    PlayerUI playerUI;
    GameController gameController;
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        playerUI = GetComponent<PlayerUI> ();



        maxHealth = 250;
        currHealth = maxHealth;

        SetStats();
    }

    public override void Die()
    {
        Debug.Log("You ded bro");
        gameController.ReloadScene();
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
