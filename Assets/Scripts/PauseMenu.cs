using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject pausebutton;
    public GameObject MainMenuPanel;


    public void PauseGame()
    {
        if (PausePanel != null)
        {
            PausePanel.SetActive(true);
        }

        if (pausebutton != null)
        {
            pausebutton.SetActive(false);
        }

        Time.timeScale = 0f;
    }

    public void ResumeButton()
    {
        if (PausePanel != null)
        {
            PausePanel.SetActive(false);
        }

        if (pausebutton != null)
        {
            pausebutton.SetActive(true);
        }

        Time.timeScale = 1f;
    }

    public void RestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        MainMenuPanel.SetActive(false);

    }
    public void MainMenuButton()
    {
        if (PausePanel != null)
        {
            PausePanel.SetActive(false);
        }

        if (MainMenuPanel != null)
        {
            SceneManager.LoadScene("MainMenu");
            //MainMenuPanel.SetActive(true);
        }

        if (pausebutton != null)
        {
            pausebutton.SetActive(false);
        }

        Time.timeScale = 0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
