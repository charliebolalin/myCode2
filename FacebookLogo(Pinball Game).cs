using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacebookLogo : MonoBehaviour
{
    [SerializeField] TwitterMouseMovement twitterLogo;

    Vector2 twitterLogoToVector;

    bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        twitterLogoToVector = transform.position - twitterLogo.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockToTwitterLogo();
           
        }
        LaunchFacebookLogo();



    }

    private void LaunchFacebookLogo()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(12f, 10f);
           
        }

    }

    public void LockToTwitterLogo()
    {
        Vector2 twitterLogoPos = new Vector2(twitterLogo.transform.position.x, twitterLogo.transform.position.y);
        transform.position = twitterLogoPos + twitterLogoToVector;

    }
}
