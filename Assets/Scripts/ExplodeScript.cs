using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeScript : MonoBehaviour
{
    public float destroyDelay;
    public float minForce;
    public float maxForce;
    public float radius;

    private void Start()
    {
        Explode();
    }

    public void Explode()
    {
        foreach(Transform t in transform)
        {
            var rb = t.GetComponent<Rigidbody>();

            if(rb != null)
            {
                rb.AddExplosionForce(Random.Range(minForce, maxForce), transform.position, radius);
                //rb.AddExplosionForce(50000, transform.position, radius);
            }

            Destroy(t.gameObject, destroyDelay);
        }

        Destroy(gameObject, destroyDelay);
    }
}
