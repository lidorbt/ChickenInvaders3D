using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenGenerator : MonoBehaviour
{
    public float spawnRange;
    public float maxClones;
    public float startingSpawnAmount;
    private Vector3 spawnPoint;
    public GameObject player;
    public GameObject chicken;
    public float startSafeRange;
    private float lastCloningTime;
    private List<GameObject> objectsToPlace = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < startingSpawnAmount; i++)
        {
            cloneChicken();
        }

        spawnRange = 75;
    }

    // Update is called once per frame
    void Update()
    {
        bool isGameOver = HeartSystem.instance.isGameOver;
        bool gameIsPaused = PauseControl.instance.gameIsPaused;

        if (Time.realtimeSinceStartup - lastCloningTime >= .3 && !isGameOver && !gameIsPaused && objectsToPlace.Count <= maxClones)
        {
            cloneChicken();
            lastCloningTime = Time.realtimeSinceStartup;
        }
    }

    private void cloneChicken()
    {
        PickSpawnPoint();

        //pick new spawn point if too close to player start
        while (Vector3.Distance(spawnPoint, Vector3.zero) < startSafeRange)
        {
            PickSpawnPoint();
        }

        GameObject chickenClone = Instantiate(chicken, spawnPoint, Quaternion.Euler(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f)));
        chickenClone.transform.parent = this.transform;
        chickenClone.SetActive(true);

        objectsToPlace.Add(chickenClone);
    }

    public void PickSpawnPoint()
    {
        spawnPoint = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f));

        if (spawnPoint.magnitude > 1)
        {
            spawnPoint.Normalize();
        }
        
        spawnPoint *= spawnRange;

        spawnPoint += player.transform.position;
    }
}

