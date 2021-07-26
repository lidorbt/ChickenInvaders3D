using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("PlayGame");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnVolumeChange(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
        Debug.Log(PlayerPrefs.GetFloat("volume"));
    }

    public void QuitGame()
    {
        Debug.Log("QuitGame");

        Application.Quit();
    }
}
