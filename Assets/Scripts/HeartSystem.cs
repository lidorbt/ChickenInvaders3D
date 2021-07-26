using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public static HeartSystem instance;

    public GameObject[] hearts;
    private int life;
    private bool dead;

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
        if(dead == true)
        {
            Debug.Log("Game Over, all hearts lost");
            //TODO: SET GAME OVER
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
                dead = true;
            }
        }
    }
}
