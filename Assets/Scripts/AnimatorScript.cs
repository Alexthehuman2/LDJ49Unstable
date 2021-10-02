using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb2d;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (rb2d.velocity.x != 0f)
        {
            anim.SetBool("isMoving", true);
        }
    }

    public void startJump()
    {
        anim.SetBool("isJumping", true);
    }
    public void endJump()
    {
        anim.SetBool("isJumping", false);
    }

    public void startMoving()
    {
        anim.SetBool("isMoving", true);
    }

    public void endMoving()
    {
        anim.SetBool("isMoving", false);
    }
}
