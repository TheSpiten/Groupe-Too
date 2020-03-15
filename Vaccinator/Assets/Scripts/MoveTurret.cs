using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTurret : MonoBehaviour
{
    public float speed;
    public GameObject Turret;
    public GameObject TurretTile;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);//converting
            //target.z = transform.position.z;

            Turret.transform.position = Vector3.MoveTowards(Turret.transform.position, TurretTile.transform.position, speed);

        }
    }
}
