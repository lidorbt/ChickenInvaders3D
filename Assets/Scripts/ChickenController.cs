using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChickenController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Debug.Log("Bullet Collision");
            Destroy(gameObject);
        }

        if (other.tag == "Player")
        {
            Debug.Log("Player Collision, Life lost");
            Destroy(gameObject);
            HeartSystem.instance.TakeDamage();
        }
    }

    private void OnMouseEnter()
    {
        CursorController.instance.ActivateRedAimCursor();
    }

    private void OnMouseExit()
    {
        CursorController.instance.ActivateAimCursor();
    }
}
