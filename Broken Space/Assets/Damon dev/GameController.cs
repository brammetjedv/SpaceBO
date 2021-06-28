using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    float currScore = 0;

    void Start()
    {
        currScore = 0;
        AddScore(10);
    }

    public void AddScore(float amount)
    {
        currScore += amount;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
