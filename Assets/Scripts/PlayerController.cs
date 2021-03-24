﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Collider2D keppi;
    [SerializeField] DrunkScript drunkScript;
    [SerializeField] private GameObject[] kolpakkoPrefab;
    [SerializeField] public float movementSpeed = 2.0f, jumpForce = 10f;
    public bool playerAlive;

    private Rigidbody2D rb;
    private Animator animator;

    private float moveHorizontal, moveVertical, jump, xScale, jumpForceMultiplier = 2;

    private bool isGrounded, canJump, jumpKeyPressed;

   
    

    private void Awake()
    {
        
        xScale = transform.localScale.x;
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        keppi = GameObject.Find("Keppi").GetComponent<BoxCollider2D>();
        keppi.enabled = false;
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("Walk", true);
        playerAlive = true;
        canJump = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
            if (isGrounded)
            {
                canJump = true;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kolpakko"))
        {
            drunkScript.MoreDrunk(10);
            Destroy(GameObject.FindGameObjectWithTag("Kolpakko"));
            
        }
    }



    void Update()
    {
        Debug.Log(isGrounded);
        Debug.Log("Voi hyppää " + canJump);
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            drunkScript.MoreDrunk(5);
        } 
    }

  
    private void Jumping()
    {
        if (playerAlive && canJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpKeyPressed = true;
                if (jumpKeyPressed)
                {
                    rb.AddForce(Vector2.up * jumpForce * jumpForceMultiplier * Time.unscaledDeltaTime, ForceMode2D.Impulse);
                    canJump = false;
                }

            }
            
        }
    }
    

    private void FixedUpdate()
    {
        Jumping();
        HandleMovement();
    }

    private void HandleMovement()
    {
        rb.velocity = new Vector2(moveHorizontal * movementSpeed, rb.velocity.y);
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