using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    private float inputMovement;
    Rigidbody2D rigidBody;
    public bool isLookingRight = true, isOnFloor = false;
    public int maxSaltos = 2;
    private int contadorSaltos;



    //Arregla salto
    BoxCollider2D boxCollider;
    public LayerMask surfaceLayer;



    // 
    public bool isRunning;
    private Animator animator;


    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        contadorSaltos = maxSaltos;
    }


    bool CheckingFloor()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(
            boxCollider.bounds.center,
            new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y),
            0f,
            Vector2.down,
            0.2f,
            surfaceLayer
            );
        bool isOnGround = raycastHit.collider != null;
        if (isOnGround) contadorSaltos = maxSaltos;
        return isOnGround;
        // return raycastHit.collider != null;
    }

    void Update()
    {
        ProcessingMovement();
        isOnFloor = CheckingFloor();
        ProcessingJump();
    }

    void ProcessingMovement()
    {
        //Movement logic
        inputMovement = Input.GetAxis("Horizontal");
        isRunning = inputMovement != 0 ? true : false;
        animator.SetBool("isRunning", isRunning);
        rigidBody.velocity = new Vector2(inputMovement * speed, rigidBody.velocity.y);
        OrientacionPersonaje(inputMovement);

    }

    void OrientacionPersonaje(float inputMovement)
    {
        if ((isLookingRight && inputMovement < 0) || (!isLookingRight && inputMovement > 0))
        {
            isLookingRight = !isLookingRight;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }


    private void ProcessingJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && contadorSaltos > 0)
        {
            rigidBody.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            contadorSaltos--;
        }
    }
}


