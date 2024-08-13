using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public void loadHubWorld()
    {
        SceneManager.LoadScene("Test Area");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("hasQuit");
    }
    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

}
