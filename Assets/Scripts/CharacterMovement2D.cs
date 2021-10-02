using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterMovement2D : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1F;
    [SerializeField] private float jumpForce = 1F;
    
    [SerializeField] private LayerMask groundLayer = default;
    [SerializeField] private Transform groundPoint = default;
    [SerializeField] private Transform leftPoint = default;
    [SerializeField] private Transform rightPoint = default;
    
    [SerializeField] private UnityEvent changeDirectionEvent = default;
    [SerializeField] private UnityEvent jumpEvent = default;
    
    private bool _isGrounded = true;
    private bool _direction = true; // false left, true right
    private float _move = 0;
    
    private Rigidbody2D _rigidbody = default;
    

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Update Movement
        _move = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector2(moveSpeed * _move, _rigidbody.velocity.y);
        
        CheckDirection();
        SlideDownWalls();

        // Jump
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            jumpEvent.Invoke();
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    private bool IsGrounded()
    {
        var colliders = Physics2D.OverlapCircleAll(groundPoint.position, .05f, groundLayer);
        _isGrounded = colliders.Length > 0;
        return _isGrounded;
    }

    private void CheckDirection()
    {
        var newDirection = _move > 0;
        
        if (_move == 0) return;
        if (_direction == newDirection) return;
        
        _direction = newDirection;
        changeDirectionEvent.Invoke();
    }

    private void SlideDownWalls()
    {
        // get collisions
        var left = Physics2D.OverlapCircleAll(leftPoint.position, .05f, groundLayer).Length;
        var right = Physics2D.OverlapCircleAll(rightPoint.position, .05f, groundLayer).Length;

        if (left > 0 && !_direction || right > 0 && _direction)
        {
            _rigidbody.velocity = new Vector2(0, _rigidbody.velocity.y);
        }
    }
    
}
