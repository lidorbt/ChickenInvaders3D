using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePauseMenuBootcamp : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        PauseControlBootcamp.instance.gameIsPaused = false;
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        ResumeGame();
        SceneManager.LoadScene(3);
    }

    public void OpenMainMenu()
    {
        ResumeGame();
        SceneManager.LoadScene(0);
    }
}
