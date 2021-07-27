using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0f;
    }

    void Update()
    {

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
