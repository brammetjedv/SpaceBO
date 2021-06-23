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
        while (enemyCount < 5)
        {
            xPos = Random.Range(29, 40);
            zPos = Random.Range(13, 20);
            Instantiate(theEnemy, new Vector3(xPos, 0.4f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(10f);
            enemyCount += 1;
        }
    }

}