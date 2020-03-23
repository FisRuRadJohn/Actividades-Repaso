using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_1 : MonoBehaviour
{
    public GameObject prefabObstacle; //lo que va a spawnear
    public int n;

    void Start()
    {


        //SpawnObstacleIn(new Vector2(transform.position.x, transform.position.y)); para que spawnee desde el propio spawner.
        SpawnNObstacles();
        SpawnObstacleA();
        SpawnObstacleB();
        

        InvokeRepeating("SpawnNObstacles", 2.0f, 2.3f);
    }

   
    void Update()
    {
       
    }

    // A

    GameObject SpawnObstacleA()
    {
        GameObject obstacle = Instantiate(prefabObstacle);
        return obstacle;
    }

    // B

    void SpawnObstacleB()
    {
        Instantiate(prefabObstacle);
    }

   // C

    void SpawnObstacleIn(Vector2 position)
    {
        Instantiate(prefabObstacle, position, Quaternion.identity);
    }

    // D

    void SpawnNObstacles() //he tenido que crear una variable publica de "n" para que funcione el invokerepeating
    {
        for (int i = 0; i < n; i++)
        {
            Instantiate(prefabObstacle);
        }
    }

}
