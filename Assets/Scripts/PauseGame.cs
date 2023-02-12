using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pauseScreen;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }
        Pause();
    }
    void Pause()
    {
        if (isPaused)
        {
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (!isPaused)
        {
            pauseScreen.SetActive(false);
            Time.timeScale = 1f;
        }
            
    }
    public void Resume()
    {
        isPaused = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        GameManager.ResetPoint();
    }
}
