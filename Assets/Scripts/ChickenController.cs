using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Debug.Log("Bullet Collision");
            Destroy(gameObject);
        }

        if (other.tag == "Player")
        {
            Debug.Log("Player Collision");
            Destroy(gameObject);
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
