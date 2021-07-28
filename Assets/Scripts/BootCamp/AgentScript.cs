using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;
    public Transform spawnPoint;
    public GameObject deadChicken;

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
            Instantiate(deadChicken, transform.position, transform.rotation).SetActive(true);
            transform.position = spawnPoint.position;
        }

        if (other.tag == "Finish")
        {
            transform.position = spawnPoint.position;
        }
    }
}
