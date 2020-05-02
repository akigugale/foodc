using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("button pressed");
        SceneManager.LoadScene(1);
    }

    public void BacktoMenu()
    {
        Debug.Log("button pressed");

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void QuitGame()
    {
        Debug.Log("button pressed");

        Debug.Log("QUIT");
        Application.Quit();
    }
}
