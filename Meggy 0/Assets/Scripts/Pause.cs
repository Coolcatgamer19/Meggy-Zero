using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{


    public int EscapeTogle;
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscapeTogle = 1 - EscapeTogle;
        }

        if (EscapeTogle == 1)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
        if (EscapeTogle == 0)
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        EscapeTogle = 0;
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }




}
