using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowersManager : MonoBehaviour
{

    private Camera mainCamera;
    public GameObject turretPrefab;
    public GameObject turretTile;
    bool isDragging = false;

    private GameObject newTurret;

    void Start()
    {
        mainCamera = Camera.main;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDragging)
        {
            Vector2 location = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            if (turretTile.GetComponent<CircleCollider2D>() ==
                Physics2D.OverlapPoint(location, 1 << LayerMask.NameToLayer("TurretTile")))
            {
                
                isDragging = true;
                
                newTurret = Instantiate(turretPrefab, turretTile.transform.position, Quaternion.identity)
                    as GameObject;
            }
            else if (Input.GetMouseButton(0) && isDragging)
            {
                Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D[] hits = Physics2D.RaycastAll(ray.origin, ray.direction);
                if (hits.Length > 0 && hits[0].collider != null)
                {
                    newTurret.transform.position = hits[0].collider.gameObject.transform.position;

                }
                    

            }
        }
    }

        
}
    
    
  

