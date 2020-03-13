using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
            FindObjectOfType<AudioManager>().Play("PlayerWin");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
