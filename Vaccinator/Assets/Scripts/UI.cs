using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    
    public static int score;
    public static int health;
    public GameObject panel;

    public static bool winScreen;
    public static bool loseScreen;

    void Start()
    {
        score = 0;
        health = 3;
    }

    
    void Update()
    {
        if (score == 3)
        {
            Time.timeScale = 0;

            winScreen = true;
        }
        else if (health == 0)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
        }
    }
}
