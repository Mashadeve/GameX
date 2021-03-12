using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveHorizontal, moveVertical, jump;
    [SerializeField]
    public float movementSpeed = 2.0f;
    [SerializeField]
    public float jumpForce = 10f;
    [SerializeField] private GameObject sword;


    private Rigidbody2D rb;
    private bool isGrounded;
    private bool isRotated;

    
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

        if (Input.GetAxisRaw("Horizontal") > 0 && isRotated == false)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            if (isRotated == false)
            {
                sword.transform.Rotate(new Vector2(transform.rotation.x, 0));
                isRotated = true;
            }
            
        }
        else if (Input.GetAxisRaw("Horizontal") < 0 && isRotated == true)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            if (isRotated == true)
            {
                sword.transform.Rotate(new Vector2(transform.rotation.x, -180));
                isRotated = false;
            }
            
        }       
    }

    
}
