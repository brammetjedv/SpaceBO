using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : CharacterStats
{
    
    public int damage = 10;
    private object OnCollisionEnter;
    

    // Start is called before the first frame update
    void Start()
    { 

  


    }

    private void dealDamage(int v, int damage)
    {
        throw new NotImplementedException();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            currHealth -= 10;
        }
    }
}
