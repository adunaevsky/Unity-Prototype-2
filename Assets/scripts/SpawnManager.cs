using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spanInterval = 1.5f;
 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpanRandomAnimal", startDelay, spanInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    SpanRandomAnimal();
        //}
    }

    void SpanRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spanPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(
            animalPrefabs[animalIndex],
            spanPos,
            animalPrefabs[animalIndex].transform.rotation
            );
    }
}
