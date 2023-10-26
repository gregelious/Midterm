using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car3Movement : MonoBehaviour
{
    public float xSpeed = 0; //horizontal speed

    private float xBorder = 8f; // left & right border

    public bool xMove = true; // true = right, false = left

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f; // moves to the right
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= xBorder) { xMove = false; } // if it goes too far right, goes left
        if (transform.position.x <= -xBorder) { xMove = true; } // if it goes too far left, goes right

        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xSpeed * 2, transform.position.y); // goes right
        }
        else // if xMove is false
        {
            transform.position = new Vector2(transform.position.x - xSpeed * 2, transform.position.y); // goes left
        }

        if (transform.position.x >= xBorder) // if past the right border
        {
            xMove = false; // goes left

        }
        if (transform.position.x <= -xBorder) // if past the left border
        {
            xMove = true; // goes right
        }
    }
}
