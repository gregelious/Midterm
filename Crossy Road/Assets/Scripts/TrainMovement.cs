using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    public float xSpeed = 0; //horizontal speed

    private float xBorder = 400f; // right border


    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f; // sets speed
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + xSpeed*8, transform.position.y); // goes right at 8 times the speed

        if (transform.position.x >= xBorder) // if past the right border
        {
            transform.position = new Vector2(-80, transform.position.y); // teleport to left of map

        }
    }
}
