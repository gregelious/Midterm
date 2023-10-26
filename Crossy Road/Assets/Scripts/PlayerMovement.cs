using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 1f; // speed

    int playerScore; // tracks score
    public Text scoreTextP1; // shows score

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y == 4.5 && playerScore > 9)
        {
            SceneManager.LoadScene("EndScene"); // go back to start screen
        }

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < 4.5)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > -4)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
        }
        else if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -8.1)
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 8.1)
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        }

       scoreTextP1.text = playerScore.ToString(); // shows the score
    }

    //fixedUpdate is called at a fixed interval
    void FixedUpdate()
    {
        
    }

    //fxn to make the snake grow
    void Grow()
    {
        
    }

    //function for collision
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Car") 
        {
            Debug.Log("Hit"); // shows up in console
            SceneManager.LoadScene("SampleScene"); // go back to start screen
        }
        if (other.tag == "Coin")
        {
            playerScore++;
        }
    }
}
