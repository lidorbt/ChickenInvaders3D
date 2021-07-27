using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public static HeartSystem instance;

    public GameObject[] hearts;
    private int life;
    public bool isGameOver;
    public GameObject gameOverMenu;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if(isGameOver == true)
        {
            //Debug.Log("Game Over, all hearts lost");
            gameOverMenu.SetActive(true);
        }
    }

    public void TakeDamage()
    {
        if (life >= 1)
        {
            life--;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                isGameOver = true;
            }
        }
    }
}
