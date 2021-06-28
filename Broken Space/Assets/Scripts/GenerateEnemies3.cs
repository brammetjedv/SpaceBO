using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies3 : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 1000)
        {
            xPos = Random.Range(-68, -65);
            zPos = Random.Range(-8, -6);
            Instantiate(theEnemy, new Vector3(xPos, -2f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(25f);
            enemyCount += 1;
        }
    }

}