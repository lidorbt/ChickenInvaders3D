using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public static PauseControl instance;
    private void Awake()
    {
        instance = this;
    }

    public bool gameIsPaused;
    public GameObject gamePauseMenu;
    void Update()
    {
        bool isGameOver = HeartSystem.instance.isGameOver;
        
        if (Input.GetKeyDown(KeyCode.P) && !isGameOver)
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            gamePauseMenu.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            gamePauseMenu.SetActive(false);
        }
    }
}