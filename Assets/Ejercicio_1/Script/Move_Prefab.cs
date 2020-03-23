using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Prefab : MonoBehaviour
{

    private Transform position;
    private float speed;
    private float timeActive;
    private int randomMove;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1, 9);

        timeActive = Random.Range(2, 12);

        randomMove = Random.Range(0, 8);
        
        position = GetComponent<Transform>();

        Destroy(gameObject, timeActive);
    }


    void FixedUpdate()
    {

        switch (randomMove)
        {
            case 0:
                position.position = position.position + (Vector3.left * speed * Time.deltaTime);
                break;
            case 1:
                position.position = position.position + ((Vector3.left + Vector3.up) * speed * Time.deltaTime);
                break;
            case 2:
                position.position = position.position + (Vector3.up * speed * Time.deltaTime);
                break;
            case 3:
                position.position = position.position + ((Vector3.right + Vector3.up) * speed * Time.deltaTime);
                break;
            case 4:
                position.position = position.position + (Vector3.right * speed * Time.deltaTime);
                break;
            case 5:
                position.position = position.position + ((Vector3.right + Vector3.down) * speed * Time.deltaTime);
                break;
            case 6:
                position.position = position.position + (Vector3.down * speed * Time.deltaTime);
                break;
            case 7:
                position.position = position.position + ((Vector3.left + Vector3.down) * speed * Time.deltaTime);
                break;
        }
    }
}
