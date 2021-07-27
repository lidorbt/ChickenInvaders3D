using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChickenController : MonoBehaviour
{
    public GameObject deadChicken;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Debug.Log("Bullet Collision");
            Instantiate(deadChicken, transform.position, transform.rotation).SetActive(true);
            Score.instance.IncreaseScore();
            Destroy(gameObject);
        }

        if (other.tag == "Player")
        {
            Debug.Log("Player Collision, Life lost");
            Destroy(gameObject);
            HeartSystem.instance.TakeDamage();
            Score.instance.IncreaseScore();
            Instantiate(deadChicken, transform.position, transform.rotation).SetActive(true);
        }
    }

    private void OnMouseEnter()
    {
        bool isGameOver = HeartSystem.instance.isGameOver;
        bool gameIsPaused = PauseControl.instance.gameIsPaused;

        if (!isGameOver && !gameIsPaused)
        {
            CursorController.instance.ActivateRedAimCursor();
        }
    }

    private void OnMouseExit()
    {
        CursorController.instance.ActivateAimCursor();
    }
}
