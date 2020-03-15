using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretTile : MonoBehaviour
{
    public GameObject thisTile;
    public GameObject Turret;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Turret.transform.position = thisTile.transform.position;
    }
}
