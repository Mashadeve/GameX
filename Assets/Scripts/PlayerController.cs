using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    [SerializeField] DrunkScript drunkScript;
    [SerializeField] private GameObject[] kolpakkoPrefab;
    private float moveHorizontal, moveVertical, jump, xScale;
    [SerializeField]
    public float movementSpeed = 2.0f, jumpForce = 10f;
    [SerializeField] private GameObject player;
    private Rigidbody2D rb;
    private Animator animator;
    private bool isGrounded;
    public bool playerAlive;


    private void Awake()
    {
        
        xScale = transform.localScale.x;
        animator = GetComponent<Animator>();
        
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("Walk", true);
        playerAlive = true;
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == GameObject.FindGameObjectWithTag("Kolpakko"))
        {
            drunkScript.MoreDrunk(10);
            Destroy(GameObject.FindGameObjectWithTag("Kolpakko"));
            
        }
    }



    void Update()
    {
        if (playerAlive)
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveHorizontal * movementSpeed, rb.velocity.y);

            if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }

            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                drunkScript.MoreDrunk(5);
            }
        }



    }
    

    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        if (moveHorizontal != 0f)
        {
            transform.localScale = new Vector3(xScale * moveHorizontal,
                                               transform.localScale.y,
                                               transform.localScale.z);
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    } 
}