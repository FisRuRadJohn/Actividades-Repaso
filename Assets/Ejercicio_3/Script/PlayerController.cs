using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rigidBody2D;
    public float speed = 100f;
    public static int puntuacion;
    public Text textoPuntos;
    private float direction;
    public GameObject deathPanel;

    private void Awake()
    {
        puntuacion = 1;
        deathPanel.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate() 
    {
        rigidBody2D.velocity = Vector2.zero;
        rigidBody2D.velocity = new Vector2(direction * speed * Time.fixedDeltaTime, 0);

        if (puntuacion < 0)
        {
            puntuacion = 0;
            textoPuntos.text = puntuacion.ToString();
            Time.timeScale = 0;
            DeathPanel();
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
           
            puntuacion++;
            textoPuntos.text = puntuacion.ToString();
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Hole"))
        {

            puntuacion = puntuacion - 2;
            textoPuntos.text = puntuacion.ToString();
            other.gameObject.SetActive(false);

          
        }
        if (other.gameObject.CompareTag("BlockSign"))
        {

            puntuacion = puntuacion - 2;
            textoPuntos.text = puntuacion.ToString();
            other.gameObject.SetActive(false);

           
        }
        
    }

    private void DeathPanel()
    {
        deathPanel.gameObject.SetActive(true);
    }
}

