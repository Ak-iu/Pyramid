using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    private bool jump = false;
    private bool roll = false;
    
    
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed",Mathf.Abs(horizontalMove) );
        
        
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            
        }
        if (Input.GetButtonDown("Crouch"))
        {
            roll= true;
            animator.SetBool("Rolling",true);
        }
    }

    public void OnLanding()
    {
        animator.SetBool("Jumping",false);
    }
    
    public void EndRolling()
    {
        animator.SetBool("Rolling", false);
    }

    void FixedUpdate()
    {   
        //Move Player IF ALIVEF
        bool alive = !animator.GetBool("Dead");
        
        controller.Move(horizontalMove * Time.fixedDeltaTime,roll,jump,alive);
        jump = false;
        roll = false;
    }
}
