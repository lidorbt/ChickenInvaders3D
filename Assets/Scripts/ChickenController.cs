using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChickenController : MonoBehaviour
{
    public GameObject player;
    private Rigidbody body;
    private float startingTime;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        startingTime = Time.realtimeSinceStartup;
    }

    void FixedUpdate()
    {
        bool isGameOver = HeartSystem.instance.isGameOver;
        bool gameIsPaused = PauseControl.instance.gameIsPaused;

        if (!isGameOver && !gameIsPaused)
        {
            Vector3 toTarget = Vector3.Normalize(player.transform.position - transform.position);
            float speed = Random.Range(10f, 14f) + (0.2f * (Time.realtimeSinceStartup - startingTime));

            body.velocity = toTarget * speed;
        }
    }

    public GameObject deadChicken;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Instantiate(deadChicken, transform.position, transform.rotation).SetActive(true);
            Score.instance.IncreaseScore();
            Destroy(gameObject);
        }

        if (other.tag == "Player")
        {
            Instantiate(deadChicken, transform.position, transform.rotation).SetActive(true);
            HeartSystem.instance.TakeDamage();
            Score.instance.IncreaseScore();
            Destroy(gameObject);
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
