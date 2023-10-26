using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float xSpeed = 0; //horizontal speed

    private float xBorder = 10f; // left & right border


    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f; // moves to the right
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            xSpeed = 0.0125f * 6 / 5;
        }
        if (transform.position.y < -1)
        {
            xSpeed = 0.0125f;
        }

        transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); // goes right

        if (transform.position.x >= xBorder) // if past the right border
        {
            transform.position = new Vector2(-xBorder, transform.position.y); // goes left

        }
    }
}
