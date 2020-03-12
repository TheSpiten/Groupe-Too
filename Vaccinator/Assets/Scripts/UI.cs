using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    public static int score;
    public static int health;
    public GameObject losePanel;
    public GameObject winPanel;

    public static bool winScreen;
    public static bool loseScreen;

    void Start()
    {
        score = 0;
        health = 3;
    }

    
    void Update()
    {
        if (score == 23)
        {
            Time.timeScale = 0;

            winScreen = true;
        }

        else if (health == 0)
        {
            Time.timeScale = 0;
            losePanel.SetActive(true);
        }

        else if (score == 100)
        {
            Time.timeScale = 0;
            losePanel.SetActive(true);
        }
    }
}
