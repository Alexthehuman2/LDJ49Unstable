using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScript : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
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
