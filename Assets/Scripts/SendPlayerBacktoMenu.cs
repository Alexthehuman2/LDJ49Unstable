using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendPlayerBacktoMenu : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("why is this not working");
        if (collision.tag == "Player")
        {
            //set player's position back to spawn
            //+1 to singleton integer, determines how broken the screen is.
            Debug.Log("why is this not working");
            SceneManager.LoadScene(0);

        }
    }
}
