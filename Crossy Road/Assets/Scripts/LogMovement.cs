using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMovement : MonoBehaviour
{
    public float xSpeed = 0.0125f; //horizontal speed

    private float xBorder = 10f; // left & right border


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - (xSpeed / 3), transform.position.y); // goes left 
        

        if (transform.position.x <= -xBorder) // if past the left border
           {
                transform.position = new Vector2(xBorder, transform.position.y);  // teleport to right of map

        }
        }
}
