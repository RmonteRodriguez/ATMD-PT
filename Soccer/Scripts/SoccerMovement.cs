using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    private Vector2 movement;

    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
