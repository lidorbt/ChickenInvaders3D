using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Debug.Log(audioSource.volume + ", " + PlayerPrefs.GetFloat("volume"));
        audioSource.volume =  PlayerPrefs.GetFloat("volume");
        Debug.Log(audioSource.volume + ", " + PlayerPrefs.GetFloat("volume"));
    }

    //void Update()
    //{
    //    PlayerPrefs.GetFloat("volume");
    //}
}
