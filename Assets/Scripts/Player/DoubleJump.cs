using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValues;
    private float moveInput;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Awake()
    {
        extraJumps = extraJumpsValues;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");
        Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
    // Update is called once per frame
    void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValues;
            Debug.Log("extra Jumps sekarang: "+extraJumps);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) &&  extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
            Debug.Log(extraJumps);
        }
        //else if (Input.GetKeyDown(KeyCode.UpArrow) &&  extraJumps == 0 && isGrounded == true)
        //{
        //    rb.velocity = Vector2.up * jumpForce;
        //}
    }
}
