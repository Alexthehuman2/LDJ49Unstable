using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject Spawn = default;
    private GameObject Player = default;
    private int checkpoint = 0;
    
    private void Start()
    {
        Spawn = GameObject.FindGameObjectWithTag("Checkpoint");
        Player = GameObject.FindGameObjectWithTag("Player");
        checkpoint = CheckPointSGT.Instance.val;
        MovePlayerToSpawn();
    }
    
    private void MovePlayerToSpawn()
    {
        switch (checkpoint)
        {
            case 0:
                Player.transform.position = Spawn.transform.position;
                break;
            default:
                Debug.Log("This shouldn't happen, report this on Trello");
                break;
        }
        
    }

    public void OnPlayerDeath()
    {
        MovePlayerToSpawn(); 
    }
}
