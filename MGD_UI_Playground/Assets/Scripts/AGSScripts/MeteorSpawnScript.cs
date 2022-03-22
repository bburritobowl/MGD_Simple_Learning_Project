using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawnScript : MonoBehaviour
{
    public GameObject meteorPrefab;
    public GameObject meteorShieldPrefab;
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 3f;
    public float spawnXLimit = 6f;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        if(Random.Range(0, 100) >= 20)
        {
            //Create a meteor at a random x position
            float random = Random.Range(-spawnXLimit, spawnXLimit);
            Vector3 spawnPos = transform.position + new Vector3(random, 0f, 0f);
            Instantiate(meteorPrefab, spawnPos, Quaternion.identity);
        }
        else
        {
            //Create a meteor at a random x position
            float random = Random.Range(-spawnXLimit, spawnXLimit);
            Vector3 spawnPos = transform.position + new Vector3(random, 0f, 0f);
            Instantiate(meteorShieldPrefab, spawnPos, Quaternion.identity);
        }

        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
