using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    private Animator _anim;
    private SpriteRenderer _renderer;
    [SerializeField] private AudioSource jump;
    [SerializeField] private AudioSource step;
    [SerializeField] private AudioSource land;
    private void Start()
    {
        _anim = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    public void startJump()
    {
        _anim.SetBool("isJumping", true);
        jump.Play();
    }
    public void endJump()
    {
        _anim.SetBool("isJumping", false);
        land.Play();
    }

    public void startMoving()
    {
        _anim.SetBool("isMoving", true);
    }

    public void endMoving()
    {
        _anim.SetBool("isMoving", false);
    }

    public void FlipSpriteX()
    {
        _renderer.flipX = !_renderer.flipX;
    }
    
    public void FlipSpriteY()
    {
        _renderer.flipY = !_renderer.flipY;
    }

    public void ResetAnimation()
    {
        _renderer.flipY = false;
        endJump();
        endMoving();
    }
    
}
