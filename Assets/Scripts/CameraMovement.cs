using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private bool canMove;
    [SerializeField] private float speedToMove;
    [SerializeField] private UnityEvent onMovementEnd = default;
    private CharacterMovement2D player_move;

    private void Start()
    {
        player_move = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterMovement2D>();
        switch (CheckPointSGT.Instance.val)
        {
            case 0:
                transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
                break;
            case 1:
                transform.position = new Vector3(transform.position.x, -10.5f, transform.position.z);
                break;
            case 2:
                transform.position = new Vector3(transform.position.x, -21.5f, transform.position.z);
                break;
            case 3:
                transform.position = new Vector3(transform.position.x, -58.5f, transform.position.z);
                break;
            default:
                break;
        }
    }
    private void Update()
    {
        if (canMove)
        {
            if (transform.position.y > -10.5 && CheckPointSGT.Instance.val == 0)
            {
                transform.position -= new Vector3(0, speedToMove * Time.deltaTime, 0);
            }
            else if (transform.position.y > -21.5 && CheckPointSGT.Instance.val == 1)
            {
                transform.position -= new Vector3(0, speedToMove * Time.deltaTime, 0);
            }
            else if (transform.position.y > -58.5 && CheckPointSGT.Instance.val == 2)
            {
                transform.position -= new Vector3(0, speedToMove * Time.deltaTime, 0);
            }
            else
            {
                canMove = false;
                player_move.canMove(true);
                onMovementEnd.Invoke();
            }
        }
    }

    public void enableMovement()
    {
        canMove = true;
    }

    
}
