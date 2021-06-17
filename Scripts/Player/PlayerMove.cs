using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{   

    // --JUDEJIMAS ZOTOV-------------------
    private Rigidbody2D rbPlayer;
    private float horizontalMove;
    [SerializeField] private float speedMove;
    private bool moveLeft;
    private bool moveRight;


    //Jump and (GroundCheck(is Antarsoft))
    [SerializeField] private float jumpForce;
    [SerializeField] private bool isGrounded = false;
    [SerializeField] Transform groundCheck;
    [SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask groundLayer;
    private bool canUp;


    // -----------------------------------------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;
        canUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canUp)
        {
            if (isGrounded)
            {
               rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, jumpForce); 
            }

            //rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, jumpForce); 
            
        }
    }

    private void FixedUpdate() 
    {
        rbPlayer.velocity = new Vector2(horizontalMove, rbPlayer.velocity.y);

        Movement();
        GroundCheck();
    }


    // ---------------------------------------------------------------------------------------------


    public void PointerDownLeft()
    {
        moveLeft = true;
    }
    public void PointerUpLeft()
    {
        moveLeft = false; 
    }

    public void PointerDownRight()
    {
        moveRight = true;
    }
    public void PointerUpRight()
    {
       moveRight = false; 
    }

    public void PointerDownUp()
    {
        canUp = true;
    }
    public void PointerUpUp()
    {
        canUp = false;
    }




    private void Movement()
    {
        if (moveLeft)
        {
            horizontalMove = -speedMove;
            //rbPlayer.velocity = new Vector2(-speedMove, rbPlayer.velocity.y);
        }

        else if (moveRight)
        {
            horizontalMove = speedMove;
            //rbPlayer.velocity = new Vector2(speedMove, rbPlayer.velocity.y);
        }
        else
        {
            horizontalMove = 0;
            //rbPlayer.velocity = new Vector2(0, rbPlayer.velocity.y);
        }
    }


    private void GroundCheck()
    {
        isGrounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, groundCheckRadius, groundLayer);

        if (colliders.Length > 0)
        {
            isGrounded = true;
        }
    }
}
