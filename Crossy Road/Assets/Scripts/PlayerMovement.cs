using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 1f; // speed
    private float logSpeed = 0.0125f; // speed when player is on log

    int playerScore; // tracks score
    public Text scoreTextP1; // shows score

    private bool onLog = false; // true if player is standing on log

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0; // sets score to 0
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y == 4.5 && playerScore > 9) // if player got all coins and goes above the map
        {
            SceneManager.LoadScene("EndScene"); // shows end screen
        }

        if (transform.position.y != -1.5) // if it's definetly not on a log
        {
            onLog = false; // sets onLog to false;
        }

        if (onLog == true) // if it's on a log
        {
            transform.position = new Vector2(transform.position.x - (logSpeed / 3), transform.position.y); // player goes the same speed and direction as log
            if (transform.position.x < -9.5 || transform.position.x > 9.5) // if player is outside map
            {
                SceneManager.LoadScene("SampleScene"); // restarts game
            }
        }

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < 4.5) // is player presses W and they're in the map
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed); // player goes up 1 space
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > -4) // is player presses S and they're in the map
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed); // player goes down 1 space
        }
        else if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -8.1) // is player presses A and they're in the map
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y); // player goes left 1 space
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 8.1) // is player presses D and they're in the map
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y); // player goes right 1 space
        }

       scoreTextP1.text = playerScore.ToString(); // shows the score
    }

    //function for collision
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Car") // if player hits a car, or water
        {
            //Debug.Log("Hit"); for debugging
            SceneManager.LoadScene("SampleScene"); // restart game
        }
        if (other.tag == "Coin") // if player touches a coin
        {
            playerScore++; //score goes up by 1
        }
        if (other.tag == "Log") // if player is on top of a log
        {
            onLog = true; // sets onLog to true
        }
    }
}
