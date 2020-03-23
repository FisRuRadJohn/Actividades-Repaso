using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    public float speed = 4f;

    void Start()
    {
        Invoke("Destroyer", 7f);
    }


    void Update()
    {

        transform.position = transform.position + speed * Time.deltaTime * Vector3.down;
    }

    private void Destroyer()
    {
        Destroy(gameObject);
    }
}
