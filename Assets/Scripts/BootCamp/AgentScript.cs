using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;
    public Transform spawnPoint;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();    
    }

    void Update()
    {
        float distanceFromTarget = Vector3.Distance(target.position, transform.position);

        if (distanceFromTarget <= 1)
        {
            transform.position = spawnPoint.position;
        } else
        {
            agent.SetDestination(target.position);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            //Instantiate(deadChicken, transform.position, transform.rotation).SetActive(true);
            transform.position = spawnPoint.position;
            //Destroy(gameObject);
        }

        if (other.tag == "Finish")
        {
            //Instantiate(deadChicken, transform.position, transform.rotation).SetActive(true);
            transform.position = spawnPoint.position;
            //Destroy(gameObject);
        }
    }
}
