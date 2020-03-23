using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuActs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Act1()
    {
        SceneManager.LoadScene("Act_1");
    }
    public void Act2()
    {
        SceneManager.LoadScene("Act_2");
    }
    public void Act3()
    {
        SceneManager.LoadScene("Act_3");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
