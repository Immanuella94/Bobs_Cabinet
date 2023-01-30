using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawnerScript : MonoBehaviour
{
    private float nextSpawnTime;
    private float wanderersSpawned = 0;

    [SerializeField]
    private GameObject Wanderer;
    [SerializeField]
    private float spawnDelayTime = 10;

    private void Update()
    {
        if(ShoulSpawn())
        {
            Spawn();
        }

        StopSpawning();
    }

    private void Spawn()
    {
        if (wanderersSpawned <= 2)
        {
            nextSpawnTime = Time.time + spawnDelayTime;
            Instantiate(Wanderer, transform.position, transform.rotation);
            wanderersSpawned++;
        }
    }

    private bool ShoulSpawn()
    {
        return Time.time > nextSpawnTime;
    }

    private void StopSpawning()
    {
        if (wanderersSpawned > 3)
        {
            CancelInvoke(nameof(Spawn));
        }
    }
}
