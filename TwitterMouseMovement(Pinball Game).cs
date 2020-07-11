using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwitterMouseMovement : MonoBehaviour
{
    [SerializeField] float screenHeightInUNits = 24f;
    
    float minY = 3.2f, maxY = 10.16f;

    // Update is called once per frame
    void Update()
    {
        float mousePositionInUnits = Input.mousePosition.y / Screen.height * screenHeightInUNits;
        Vector2 twitterPos = new Vector2(transform.position.x, transform.position.y);
        twitterPos.y = Mathf.Clamp(mousePositionInUnits, minY, maxY);
        transform.position = twitterPos;
    }
}
