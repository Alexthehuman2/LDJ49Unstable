using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Spawn = default;
    [SerializeField] private GameObject Checkpoint2 = default;
    [SerializeField] private GameObject Checkpoint3 = default;
    [SerializeField] private GameObject Checkpoint4 = default;
    private GameObject Player = default;
    private int checkpoint = 0;
    
    private void Start()
    {
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
            case 1:
                Player.transform.position = Checkpoint2.transform.position;
                break;
            case 2:
                Player.transform.position = Checkpoint3.transform.position;
                break;
            case 3:
                Player.transform.position = Checkpoint4.transform.position;
                break;
            default:
                break;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void OnPlayerDeath()
    {
        MovePlayerToSpawn(); 
    }
}
