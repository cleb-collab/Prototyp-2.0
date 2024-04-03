using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; 
private float startDelay = 2;
private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomSnack", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void SpawnRandomSnack()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-20, 20), 0, 18);

            int animalIndex = Random.Range(0,animalPrefabs.Length);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    
}
