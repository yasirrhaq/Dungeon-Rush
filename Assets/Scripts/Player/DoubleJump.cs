using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValues;

    public Rigidbody2D rb;

    public CharacterController2D controller;

    public Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        extraJumps = extraJumpsValues;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        controller.GroundCheck();
        //moveInput = Input.GetAxis("Horizontal");
        //Debug.Log(moveInput);
        //rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
    // Update is called once per frame
    void Update()
    {
        if (controller.m_Grounded == true)
        {
            extraJumps = extraJumpsValues;

        }
        if (Input.GetButtonDown("Jump") &&  extraJumps > 0)
        {
            rb.velocity = Vector2.up * controller.m_JumpForce;
            extraJumps--;

        }
        else if (Input.GetButtonDown("Jump") && extraJumps == 0 && controller.m_Grounded == true)
        {
            rb.velocity = Vector2.up * controller.m_JumpForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            animator.SetBool("isStickToWall", true);
            extraJumps = 1;
        }
    }
}
