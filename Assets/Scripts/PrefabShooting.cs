using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabShooting : MonoBehaviour
{
    [SerializeField]
    public Rigidbody bullet;
    
    [SerializeField]
    public Transform firePoint;
    
    private float speed = 200f;

    void Update()
    {
        bool isGameOver = HeartSystem.instance.isGameOver;

        if (Input.GetMouseButtonDown(0) && !isGameOver)
        {
            var bulletClone = Instantiate(bullet, firePoint.position, firePoint.rotation);

            bulletClone.velocity += transform.TransformVector(new Vector3(0, 0, speed));

            Destroy(bulletClone.gameObject, 3);
        }
    }
}
