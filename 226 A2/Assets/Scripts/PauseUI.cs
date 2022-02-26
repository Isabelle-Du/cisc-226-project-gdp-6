using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    public static bool GameIsPaused = true;
    public GameObject Pause;

    public void Resume()
    {
        Pause.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
