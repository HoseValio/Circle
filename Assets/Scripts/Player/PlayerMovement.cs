using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Moving factors")]
    public float forceJump = 3f;
    public float speedMoving = 5f;
    
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    
    private void Jump()
    {
        GetComponent<Score>().Increase();
        _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, forceJump);
    }

    private void Move()
    {
        _rigidbody.velocity = new Vector2(speedMoving, _rigidbody.velocity.y);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }
}

        
    
