using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightFlipperMovement : MonoBehaviour
{
    public float flipperForce;
    
    public GameObject ball;

    private Animator anim2;
    // Start is called before the first frame update
    void Start()
    {
        anim2 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            flipperForce = 500f;
            anim2.SetBool("IsMoving2", true);
        }
        else
        {
            flipperForce = 0f;
            anim2.SetBool("IsMoving2", false);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball") ;
        {
            ball.GetComponent<Rigidbody2D>().AddForce(transform.up * flipperForce);
        }
    }
}
