using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{

    public GameObject spawnee;
    public bool stopSpawning = false;
    public bool first_time = true;
    public float spawnTime;
    public float spawnDelay;

    // Use this for initialization
    void Start()
    {
        if (first_time == true)
        {
            int milliseconds = 4000;
            Thread.Sleep(milliseconds);
            first_time = false;
        }
        Invoke("SpawnObject", 2);
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(spawnee, transform.position, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}