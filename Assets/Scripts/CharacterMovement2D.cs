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
    [SerializeField] private UnityEvent landEvent = default;
    [SerializeField] private UnityEvent stopMovingEvent = default;
    [SerializeField] private UnityEvent startMovingEvent = default;

    [SerializeField]private bool _isGrounded = false;
    private bool _direction = true; // false left, true right
    private float _move = 0;
    
    private Rigidbody2D _rigidbody = default;
    

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get axis input
        var lastMove = _move;
        _move = Input.GetAxis("Horizontal");

        CheckStopMoving(_move, lastMove);
        
        // apply velocity
        _rigidbody.velocity = new Vector2(moveSpeed * _move, _rigidbody.velocity.y);
        
        CheckDirection();
        SlideDownWalls();

        // Jump
        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            jumpEvent.Invoke();
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    private bool IsGrounded()
    {
        var colliders = Physics2D.OverlapCircleAll(groundPoint.position, .05f, groundLayer);

        var wasGrounded = _isGrounded;
        _isGrounded = colliders.Length > 0;
        
        if (!wasGrounded && _isGrounded)
        {
            landEvent.Invoke();
            _isGrounded = true;
        }

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

    private void CheckStopMoving(float move, float lastMove)
    {
        if (move == 0 && lastMove != 0)
        {
            stopMovingEvent.Invoke();
        }
        if (move != 0 && lastMove == 0)
        {
            startMovingEvent.Invoke();
        }
    }
    
    public void mirror()
    {
        transform.localScale = new Vector3(transform.localScale.x * -1, 1, 1);
    }
}
