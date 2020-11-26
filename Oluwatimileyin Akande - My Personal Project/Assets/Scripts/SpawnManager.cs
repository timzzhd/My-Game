using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject[] objectPrefabs;
    private float spawnRangeX = 0;
    private float spawnPosZ = 0;




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
           
            // Randomly generate animal index and spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0, spawnPosZ);

            int objectIndex = Random.Range(0, objectPrefabs.Length);

            Instantiate(objectPrefabs[objectIndex], spawnPos, objectPrefabs[objectIndex].transform.rotation);

        }

    }
}
