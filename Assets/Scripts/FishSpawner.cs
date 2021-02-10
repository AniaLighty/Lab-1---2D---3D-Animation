using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    [SerializeField] private GameObject fishes;
    [SerializeField] private float delay;
    [SerializeField] private float delayReset = 5.5f; // time until spawn
    [SerializeField] private Vector3 spawnPos;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        
        if (delay <= 0)
        {
            delay = delayReset;
            spawnPos.y = Random.Range(-0.5f,-1.2f);
            spawnPos.x = Random.Range(-3f, 1.5f);
            Instantiate(fishes, spawnPos, Quaternion.identity);
        }

        

    }
}
