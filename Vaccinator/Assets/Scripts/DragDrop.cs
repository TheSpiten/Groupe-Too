using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool Selected;

    void Update()
    {
        if (Selected)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
<<<<<<< HEAD
        if (Selected == true)
        {
            Vector2 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mPosition.x, mPosition.y);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Selected = false;
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Selected = true;
        }
    }
   

=======
        //if (Selected == true)
        //{
        //    Vector2 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    transform.position = new Vector2(mPosition.x, mPosition.y);
        //}
        
        //if(Input.GetMouseButtonUp(0))
        //{
        //    Selected = false;
        //}
    }

    //void OnMouseOver()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        Selected = true;
    //    }
    //}
    public void OnMouseDown ()
    {
        Selected = true;
        
    }
     
    public void OnMouseUp ()
    {
        Selected = false;
    }
 
>>>>>>> Maher
}
