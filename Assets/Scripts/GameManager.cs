using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject Spawn = default;
    private GameObject Player = default;
    
    private void Start()
    {
        Spawn = GameObject.FindGameObjectWithTag("Spawn");
        Player = GameObject.FindGameObjectWithTag("Player");
        
        MovePlayerToSpawn();
    }
    
    private void MovePlayerToSpawn()
    {
        Player.transform.position = Spawn.transform.position;
    }

    public void OnPlayerDeath()
    {
        MovePlayerToSpawn(); 
    }
}
