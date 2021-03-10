using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StateManager : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseButton;
    public GameObject startButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
        if (!GameIsPaused)
        {
            pauseButton.SetActive(true);
            startButton.SetActive(false);
        }
        else 
        {
            pauseButton.SetActive(false);
            startButton.SetActive(true);
           
        }
    }
  
    public void Resume()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    public void Quit()
    {
        Application.Quit();
    }
}
