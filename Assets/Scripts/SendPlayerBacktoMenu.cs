using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendPlayerBacktoMenu : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //+1 to singleton integer, determines how broken the screen is.
            DeathCountSGT.Instance.val++;
            Debug.Log(DeathCountSGT.Instance.val);
            SceneManager.LoadScene(0);
        }
    }
}
