using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_BlockSign : MonoBehaviour
{

    public GameObject prefabBlockSign;
    public float randomRange = 10f;

    void Start()
    {
        InvokeRepeating("BlockSign", 1f, 2.3f);
    }

    void BlockSign()
    {
        Vector3 randomSpawn;
        randomSpawn.x = Random.Range(randomRange, -randomRange);
        randomSpawn.y = transform.position.y;
        randomSpawn.z = transform.position.z;

        Instantiate(prefabBlockSign, randomSpawn, Quaternion.identity);
    }


}