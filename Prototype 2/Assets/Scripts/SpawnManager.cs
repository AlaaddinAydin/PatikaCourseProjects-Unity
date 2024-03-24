using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //Tekrarlı bir şekilde bir metodu yeniden çalıştırıyor.
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {

        // Belli bir aralıkta hayvanları rastgele spawnlıyoruz    

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spwanPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), 0, spawnPosZ);
            
        Instantiate(animalPrefabs[animalIndex], spwanPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
