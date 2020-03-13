using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;
    

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void TryAgain()
    {
        
        SceneManager.LoadScene("Maher's Scene");
        UI.score = 0;
        UI.health = 3;
        Time.timeScale = 1f;
        
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
