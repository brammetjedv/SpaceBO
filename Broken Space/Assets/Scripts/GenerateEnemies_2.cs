using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies_2 : MonoBehaviour
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
            xPos = Random.Range(-85, -82);
            zPos = Random.Range(7, 9);
            Instantiate(theEnemy, new Vector3(xPos, -2, zPos), Quaternion.identity);
            yield return new WaitForSeconds(25f);
            enemyCount += 1;
        }
    }

}