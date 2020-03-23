using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Hole : MonoBehaviour
{

    public GameObject prefabHole;
    public float randomRange = 10f;

    void Start()
    {
        InvokeRepeating("Hole", 1f, 2.3f);
    }

    void Hole()
    {
        Vector3 randomSpawn;
        randomSpawn.x = Random.Range(randomRange, -randomRange);
        randomSpawn.y = transform.position.y;
        randomSpawn.z = transform.position.z;

        Instantiate(prefabHole, randomSpawn, Quaternion.identity);
    }


}
