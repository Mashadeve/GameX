using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] BeerSpawnManager beerManager;
    [SerializeField] Collider2D keppi;
    [SerializeField] DrunkScript drunkScript;
    [SerializeField] public float movementSpeed = 2.0f, jumpForce;
    public bool playerAlive, canJump;
    public bool canMove;

    private Rigidbody2D rb;
    private Animator animator;

    private float moveHorizontal, xScale, jumpForceMultiplier = 2;

    private bool isGrounded, jumpKeyPressed;

   
    

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
        canMove = false;
        StartCoroutine(startDelay());
        

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
        if (collision.gameObject.tag == "Kolpakko")
        {
            beerManager.canSpawn = true;
            beerManager.beerCount += 1;
            drunkScript.MoreDrunk(10);
            DestroyPrefab();
        }
        if (collision.gameObject.layer == 0)
        {
            drunkScript.MoreDrunk(-14);
        }

    }

    private void DestroyPrefab()
    {
        Destroy(GameObject.FindGameObjectWithTag("Kolpakko"));
    }

    void Update()
    {
        Block();
        Attack();

        Jumping();
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            drunkScript.MoreDrunk(5);
        }

    }

    IEnumerator startDelay()
    {
        
        yield return new WaitForSeconds(3f);
        canMove = true;
        
    }

    private void Jumping()
    {
        if (playerAlive && canJump && canMove)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpKeyPressed = true;
                if (jumpKeyPressed)
                {
                    rb.AddForce(Vector2.up * jumpForce * jumpForceMultiplier, ForceMode2D.Impulse);
                    canJump = false;
                }

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
        if (moveHorizontal != 0f && canMove)
        {
            rb.velocity = new Vector2(moveHorizontal * movementSpeed, rb.velocity.y);

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
    
    private void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
        }
    }
    private void Block()
    {
        if (Input.GetMouseButton(1))
        {
            animator.SetBool("Block", true);
        }
        else
        {
            animator.SetBool("Block", false);
        }
    }
}