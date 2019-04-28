using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel;
    public bool pauseIsActive;
    private void Update()
    {
        if (Input.GetButtonDown("Pause") && !pauseIsActive|| Input.GetKeyDown(KeyCode.Escape) && !pauseIsActive)
        {
            Debug.Log("pause");
            pausePanel.SetActive(true);
            Time.timeScale = 0;
            pauseIsActive = true;
            
        }
        else if (Input.GetButtonDown("Pause") && pauseIsActive || Input.GetKeyDown(KeyCode.Escape) && pauseIsActive)
        {
            Debug.Log("unpause");
            Time.timeScale = 1;
            pauseIsActive = false;
            pausePanel.SetActive(false);
        }
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
