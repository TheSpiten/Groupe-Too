using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowersManager : MonoBehaviour
{
    //public GameObject[] turrets;
    public GameObject  TurretPrefab;
    private Collider2D placement;
    private GameObject turret;
    

    void Start()
    {
        placement = GetComponent<Collider2D>();
    }

    
    void Update()
    {
       
    }
    
    
  
}
