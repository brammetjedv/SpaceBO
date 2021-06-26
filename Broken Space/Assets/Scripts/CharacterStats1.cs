using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats1 : MonoBehaviour
{
    public static float currHealth;
    public static float maxHealth;

    public bool isDead = false;

    public virtual void CheckHealth()
    {
        if (currHealth >= maxHealth)
        {
            currHealth = maxHealth;
        }
        if (currHealth < 1)
        {
            currHealth = 0;
            isDead = true;
            Die();
        }
    }

    public virtual void Die()
    {
        //override.
    }

    public void TakeDamage(float damage)
    {
        currHealth -= damage;
    }

}