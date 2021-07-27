using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject gamePauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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