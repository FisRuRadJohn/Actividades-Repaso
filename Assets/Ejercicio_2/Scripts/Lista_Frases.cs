using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lista_Frases : MonoBehaviour
{
    List<string> listaMotivacional = new List<string>();
    public Text fraseMotivacional;
    public GameObject stopButton;
    public GameObject restartButton;

    void Start()
    {
        listaMotivacional.Add("“los gamers no necesitamos la luz del sol, en casa se está de lujo.”                                         -yo xd 2020");
        listaMotivacional.Add("“Remember Salpeper”                                        -Jägger 2016");
        listaMotivacional.Add("“Sal de casa y sonríe. Sonríe a los problemas, a los imprevistos, al mal tiempo, y a las personas… Al finalizar el día, quizás descubras que tienes el COVID-19, pero tú habrás sonreído.”");
        listaMotivacional.Add("“Let's GOOOOOOOOOOOOOU”                                   -Knekro 2015");
        listaMotivacional.Add("“Las cosas buenas llegan a los que saben esperar en casa”");

        //Debug.Log(listaMotivacional[3]);
        Frases();

        restartButton.gameObject.SetActive(false);
        stopButton.gameObject.SetActive(true);

        InvokeRepeating("RandomFrase", 10.0f, 10.0f);
    }

    
   

    void Frases()
    {
        for (int i = 0; i < listaMotivacional.Count; i++)
        {
            Debug.Log(listaMotivacional[i]);
        }
    }

    void RandomFrase()
    {
        int tamagnolista = listaMotivacional.Count;
        int random = Random.Range(0, tamagnolista - 1);
        fraseMotivacional.text = listaMotivacional[random].ToString();
    }

    public void SkipButton()
    {
        int randomN = Random.Range(0, 5);
        fraseMotivacional.text = listaMotivacional[randomN];
    }

    public void StopTime()
    {
        Time.timeScale = 0;
        stopButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(true);
        
    }
    public void RestartTime()
    {
        Time.timeScale = 1;
        restartButton.gameObject.SetActive(false);
        stopButton.gameObject.SetActive(true);
    }
}
