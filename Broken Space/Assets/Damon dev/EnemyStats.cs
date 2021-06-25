using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
    private float scoreAddAmount = 10;

    GameController gameController;

    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        maxHealth = 100;
        currHealth = maxHealth;
    }

    private void Update()
    {
        CheckHealth();
    }


    public override void Die()
    {
        gameController.AddScore(scoreAddAmount);
        Destroy(gameObject);
    }

}
