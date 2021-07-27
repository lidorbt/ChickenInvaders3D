using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePauseMenu : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
