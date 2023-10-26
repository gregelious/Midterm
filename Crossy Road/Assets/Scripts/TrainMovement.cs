using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    public float xSpeed = 0; //horizontal speed

    private float xBorder = 400f; // left & right border


    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f; // moves to the right
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + xSpeed*8, transform.position.y); // goes right

        if (transform.position.x >= xBorder) // if past the right border
        {
            transform.position = new Vector2(-80, transform.position.y); // goes left

        }
    }
}
