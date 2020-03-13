using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{

    public AudioSource FX;
    public AudioClip Clicked;

    
    public void ClickSound()
    {
        FX.PlayOneShot(Clicked);
    }
}
