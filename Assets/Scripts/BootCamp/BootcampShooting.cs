using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootcampShooting : MonoBehaviour
{
    [SerializeField]
    public Rigidbody bullet;

    [SerializeField]
    public Transform firePoint;
    
    private float speed = 50f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            var bulletClone = Instantiate(bullet, firePoint.position, firePoint.rotation);

            bulletClone.velocity += mouseRay.direction * speed;

            Destroy(bulletClone.gameObject, 3);
        }
    }
}
