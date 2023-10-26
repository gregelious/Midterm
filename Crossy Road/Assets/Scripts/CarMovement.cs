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
        if (transform.position.y < 4)
        {
            xSpeed = 0.0125f * 250 / 100;
        }
        if (transform.position.y < 2)
        {
            xSpeed = 0.0125f * 200 / 100;
        }
        if (transform.position.y < 0)
        {
            xSpeed = 0.0125f * 150 / 100;
        }
        if (transform.position.y < -1)
        {
            xSpeed = 0.0125f * 125 / 100;
        }
        if (transform.position.y < -3)
        {
            xSpeed = 0.0125f;
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); // goes right

        if (transform.position.x >= xBorder) // if past the right border
        {
            transform.position = new Vector2(-xBorder, transform.position.y); // goes left

        }
    }
}
