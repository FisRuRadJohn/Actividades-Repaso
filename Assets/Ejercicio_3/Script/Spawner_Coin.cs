﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Coin : MonoBehaviour
{

    public GameObject prefabCoin;
    public float randomRange = 10f;

    void Start()
    {
        InvokeRepeating("Coin", 1f, 2.3f);
    }

    void Coin()
    {
        Vector3 randomSpawn;
        randomSpawn.x = Random.Range(randomRange, -randomRange);
        randomSpawn.y = transform.position.y;
        randomSpawn.z = transform.position.z;

        Instantiate(prefabCoin, randomSpawn, Quaternion.identity);
    }


}