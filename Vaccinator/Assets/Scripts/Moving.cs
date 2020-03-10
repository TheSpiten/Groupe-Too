using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed;
    public Waypoints wayPoints;
   
    private int waypointnumber;
   
    void Start()
    {
       // wayPoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
        //timer = 11;
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, wayPoints.waypoints[waypointnumber].position, speed * Time.deltaTime);

        Vector3 direction = wayPoints.waypoints[waypointnumber].position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (Vector2.Distance(transform.position, wayPoints.waypoints[waypointnumber].position) < 0.1f)
        {
            if (waypointnumber < wayPoints.waypoints.Length - 1)
            {
                waypointnumber++;
            }


        }


    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            UI.health -= 1;
            Destroy(gameObject);
        }
        else if (col.gameObject.tag== "bullet")
        {
            UI.score += 1;
            Destroy(gameObject);
        }
    }

}
