﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {

    }

    public void Play()
    {
        
        SceneManager.LoadScene("Maher's Scene");
        
       
        
    }

    public void Quit()
    {
        Application.Quit();
    }

}
