using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    [HideInInspector]
    public float moveHorizontal, moveVertical, jump, xScale;
    [SerializeField]
    public float movementSpeed = 2.0f;
    [SerializeField]
    public float jumpForce = 10f;
    [SerializeField] private GameObject player;
    private Rigidbody2D rb;

    private bool isGrounded;


    private void Awake()
    {
        xScale = transform.localScale.x;
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveHorizontal * movementSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        HandleMovement();

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveHorizontal * movementSpeed, rb.velocity.y);
    }

    private void HandleMovement()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        if (moveHorizontal != 0f)
        {
            transform.localScale = new Vector3(xScale * moveHorizontal,
                                               transform.localScale.y,
                                               transform.localScale.z);
        }
    }
}