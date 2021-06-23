using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] float damage;
    float LastAttackTime = 0;
    float AttackCooldown = 2;

    [SerializeField] float stoppingDistance;

    NavMeshAgent agent;

    GameObject target;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        float dist = Vector3.Distance(transform.position, target.transform.position);
        if(dist < stoppingDistance)
        {
            StopEnemy();
            if(Time.time - LastAttackTime >= AttackCooldown)
            {
                LastAttackTime = Time.time;
                target.GetComponent<CharacterStats>().TakeDamage(damage);
                target.GetComponent<CharacterStats>().CheckHealth();
            }

        }
        else
        {
            GoToTarget();
        }
    }

    private void GoToTarget()
    {
        agent.isStopped = false;
        agent.SetDestination(target.transform.position);
    }

    private void StopEnemy()
    {
        agent.isStopped = true;
    }
}
