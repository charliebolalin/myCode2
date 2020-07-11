using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipperMovement : MonoBehaviour
{
    public float flipperForce;
    public GameObject ball;
    

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            flipperForce = 500f;
            anim.SetBool("IsMoving", true);
            
        }
        else
        {
            flipperForce = 0f;
            anim.SetBool("IsMoving", false);
        }
       
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            ball.GetComponent<Rigidbody2D>().AddForce(transform.up * flipperForce);
        }
    }

   
    }



