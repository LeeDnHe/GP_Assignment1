using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager i;
    // Start is called before the first frame update
    public int score = 0;
    public float time=0;
    public int objScore;
    public float deadTime;
    void Start()
    {
        if (i == null)
            i = this;
  
    }

    public void EnemyDeath()
    {
        score++;
    }
    // Update is called once per frame
    void Update()
    {
        if(score >= objScore)
        {
            SceneManager.LoadScene("WinScene");
        }
        else if(time > deadTime)
        {
            SceneManager.LoadScene("LoseScene");
        }
        time += Time.deltaTime;
    }
}
