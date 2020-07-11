using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Text pressEnterText;

    public GameObject ball;

    private Rigidbody2D ballRigidBody2d;

    public float ballForceX;
    public float ballForceY;


    private void Start()
    {

        ballRigidBody2d =  GetComponent<Rigidbody2D>();
        ballRigidBody2d.isKinematic = true;
    }

    private void Update()
    {
     
        LaunchTheBall();
     
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
  
        if (collision.gameObject.tag == "Left Flipper")
        {
            
            ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(ballForceX, ballForceY));

        }
        else if ( collision.gameObject.tag == "Right Flipper")
        {
           
            ball.GetComponent<Rigidbody2D>().AddForce(new Vector2(ballForceX, ballForceY));
        }
    }

    public void LaunchTheBall()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ballRigidBody2d.isKinematic = false;
            GetComponent<Rigidbody2D>().velocity = new Vector2(5f, -5f);
            pressEnterText.enabled = false;
        }
    }

   




}
