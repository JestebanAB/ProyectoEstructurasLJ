using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject PauseButton;
    [SerializeField] private GameObject PauseMenu;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void pause()
    {
        Time.timeScale = 0f;
        PauseButton.SetActive(false);
        PauseMenu.SetActive(true);
        Cursor.visible = true; // Hacer el cursor visible
        Cursor.lockState = CursorLockMode.None; // Desbloquear el cursor
        isPaused = true;
    }

    public void resume()
    {
        Time.timeScale = 1f;
        PauseButton.SetActive(true);
        PauseMenu.SetActive(false);
        Cursor.visible = false; // Hacer el cursor invisible
        Cursor.lockState = CursorLockMode.Locked; // Bloquear el cursor
        isPaused = false;
    }

    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void exit()
    {
        Debug.Log("Cerrando juego...");
        Application.Quit();
    }
}
