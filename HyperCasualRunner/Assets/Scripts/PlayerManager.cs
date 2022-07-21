using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool GameOver;
    public GameObject GameOverPanel;
    void Start()
    {
        GameOver=false;
        Time.timeScale=1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameOver)
        {

            Time.timeScale=0;
            GameOverPanel.SetActive(true);
        }
    }
}
