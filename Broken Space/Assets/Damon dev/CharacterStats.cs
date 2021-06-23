using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public float currHealth;
    public float maxHealth;

    public bool isDead = false;

    public virtual void CheckHealth()
    {
        if (currHealth >= maxHealth)
        {
            currHealth = maxHealth;
        }
        if (currHealth< 0)
        {
            currHealth = 0;
            isDead = true;
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
