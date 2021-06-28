using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour
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
            xPos = Random.Range(-105, -108);
            zPos = Random.Range(-17, -15);
            Instantiate(theEnemy, new Vector3(xPos, -2f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(25f);
            enemyCount += 1;
        }
    }

}
