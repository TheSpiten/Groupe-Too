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

   

    void Start()
    {
        score = 0;
        health = 3;
        
    }


    void Update()
    {
        if (score == 25)
        {
            Time.timeScale = 0;


            winPanel.SetActive(true);
        }

        else if (health == 0)
        {

            Time.timeScale = 0;

            losePanel.SetActive(true);

        }


    }
    
}
