using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    private float xMovement;
    private float yMovement;
    [Range(0f, 20f)]
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    private void FixedUpdate()
    {
        xMovement = 0f;
        yMovement = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(xMovement, yMovement);

        rb.velocity = (movement * speed);
    }
}
