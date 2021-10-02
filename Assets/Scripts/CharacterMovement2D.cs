using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement2D : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1F;
    [SerializeField] private float jumpForce = 1F;

    private Rigidbody2D _rigidbody = default;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Update Movement
        var move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move, 0, 0) * (Time.deltaTime * moveSpeed);
        
        // Ground check
        //if(!Mathf.Approximately(0, move))
        
        // Jump
        if (Input.GetButtonDown("Jump"))
        {
            _rigidbody.AddForce(new Vector2(0, jumpForce));
        }
        
    }
}
