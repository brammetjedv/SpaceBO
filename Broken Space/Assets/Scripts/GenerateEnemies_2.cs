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
        while (enemyCount < 5)
        {
            xPos = Random.Range(-6, -3);
            zPos = Random.Range(17, 19);
            Instantiate(theEnemy, new Vector3(xPos, 1.5f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(10f);
            enemyCount += 1;
        }
    }

}