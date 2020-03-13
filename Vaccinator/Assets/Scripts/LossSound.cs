using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossSound : MonoBehaviour
{
    
    void Start()
    {
            FindObjectOfType<AudioManager>().Play("PlayerLoss");
    }

    
    void Update()
    {
        
    }
}
