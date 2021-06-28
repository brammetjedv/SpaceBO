using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public string LevelToLoad;
    private float timer = 78f;
    private Text timerSeconds;
    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("0");
        if (timer <= 0)
        {
            Application.LoadLevel(LevelToLoad);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        }
    }
}
