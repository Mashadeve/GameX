using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    [SerializeField] BeerSpawnManager beerManager;
    [SerializeField] Collider2D keppi;
    [SerializeField] DrunkScript drunkScript;
    [SerializeField] private GameObject[] kolpakkoPrefab;
    [SerializeField] public float movementSpeed = 2.0f, jumpForce;
    public bool playerAlive, canJump;
    public bool canMove;

    private Rigidbody2D rb;
    private Animator animator;

    private float moveHorizontal, moveVertical, jump, xScale, jumpForceMultiplier = 2;

    private bool isGrounded, jumpKeyPressed;

   
    

    private void Awake()
    {
        
        xScale = transform.localScale.x;
        animator = GetComponent<Animator>();
        
    }

    void Start()
    {
        Debug.Log("liikkuminen on" + canMove);
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

    public void OnTriggerEnter2D(Collider2D Bisse)
    {
        if (Bisse.gameObject.tag == "Kolpakko")
        {
            beerManager.canSpawn = true;
            beerManager.beerCount += 1;
            drunkScript.MoreDrunk(10);
            DestroyPrefab();
        }
        else
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
}