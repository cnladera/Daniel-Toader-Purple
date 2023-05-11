using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour

{
    //Game manager object
    [Header("Game Controller Object for controlling this game")]
    public GameController gameController;
    [Header("Default Velocity")]
    public float velocity = 5;
    //Phyisics for the funny looking bird
    private Rigidbody2D rb;
    // Height of the bird on the Y axis
    private float objectHeight;


    // Start is called before the first frame update
    void Start()
    {
        //Game Controller component
        gameController = GetComponent<GameController>();
        //Speed for the game is at a playing state
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        //Object Height equals the size of the height of the sprite
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //If the LMB is clicked
        if (Input.GetMouseButtonDown(0))
        {
            //The bird will float upwards on the Y axis and float back down on Y axis
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("GameController").GetComponent<GameController>().GameOver();
        {
            Time.timeScale = 0;
        }

    }

}
