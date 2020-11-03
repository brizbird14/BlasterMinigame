using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Drag the Character Controller 2D script into here;
    // Now any reference to "controller" will ref that script
    /** public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    // Update is called once per frame
    
    void Update()
    {
        // Gets user input for direction on horizontal axis
        // A or left arrow = -1, D or right arrow = 1
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    }

    void FixedUpdate()
    {
        // Move our character
        // Ultimately, take input from Update and apply here

        // Move takes 3 inputs: horizontal, crouch, jump
        // Since bokki only uses horizontal, false to others
        // Time.fixedDeltaTime = time elapsed since function last called --> moves same amt every time called
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
    **/

    public float speed;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb2d.AddForce(movement * speed);
    }


}
