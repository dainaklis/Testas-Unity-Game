using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallHoopMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool movingRight = true;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 8.3)
        {
            movingRight = false;
        }
        if(transform.position.x < -8.3)
        {
            movingRight = true;
        }
    }

    private void FixedUpdate() 
    {   
        if (movingRight)
        {
            moveRight();
        }
        else
        {
            moveLeft();
        }
        
    }

    private void moveRight()
    {
        rb.velocity = new Vector2(5, 0);
    }

    private void moveLeft()
    {
        rb.velocity = new Vector2(-5, 0);
    }


}
