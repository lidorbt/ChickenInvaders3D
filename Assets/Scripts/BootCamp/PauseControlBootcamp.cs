using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControlBootcamp : MonoBehaviour
{
    public static PauseControlBootcamp instance;

    private void Awake()
    {
        instance = this;
    }

    public bool gameIsPaused;
    public GameObject gamePauseMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            //gamePauseMenu.sort
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
