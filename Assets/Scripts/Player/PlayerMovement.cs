using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public Animator animator;
    
    //Static variable to move player
    public static bool canMove;

    public float runSpeed = 40f;


    private bool isClimbing;

    float horizontalMove = 0f;
    float verticalMove = 0f;

    bool jump = false;


    void Start()
    {
        canMove = true;
        Vector3 screenToPoint = Camera.main.WorldToViewportPoint(transform.position);
    }

    // Update is called once per frame
    void Update () {

        if (canMove)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            animator.SetFloat("speed", Mathf.Abs(horizontalMove));

            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
                animator.SetBool("isJumping", true);
            }

          
           
        }
	}

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
      

    }


}
