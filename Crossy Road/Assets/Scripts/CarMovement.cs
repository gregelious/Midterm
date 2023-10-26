using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float xSpeed = 0; //horizontal speed

    private float xBorder = 10f; // left & right border

    private bool xMove = true; // true = right, false == left

    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.y < 4) // last road
        {
            xSpeed = 0.0125f * 250 / 100; // 2.5 times speed
            xMove = true; // goes right
        }
        if (transform.position.y < 2) // 3rd road
        {
            xSpeed = 0.0125f * 200 / 100; // 2 times speed
            xMove = false;
        }
        if (transform.position.y < 0)// 2nd road
        {
            xSpeed = 0.0125f * 150 / 100; // 1.5 times speed
            xMove = true;// goes right
        }
        if (transform.position.y < -3)// 1st road
        {
            xSpeed = 0.0125f; // normal speed
            xMove = true;// goes right
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (xMove == true) // if going right
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); // goes right

            if (transform.position.x >= xBorder) // if past the right border
            {
                transform.position = new Vector2(-xBorder, transform.position.y); // teleport to left of map

            }
        }
        else // if going left
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y); // goes left

            if (transform.position.x <= -xBorder) // if past the left border
            {
                transform.position = new Vector2(xBorder, transform.position.y); // teleport to right of map

            }
        }
    }
}
