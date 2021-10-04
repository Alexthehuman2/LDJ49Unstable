using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1); //Loads the first scene in build setting
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1); //Loads the first Scene in Build setting
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0); //Loads the 0th Scene in Build Setting
    }

    private void ExitGame()
    {
        Application.Quit(); //Exits the game when the game is built.
    }

    public void winGame()
    {
        SceneManager.LoadScene(2);
    }
}
