using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    public static bool GameIsPaused = true;
    public GameObject Pause;
    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void Resume()
    {
        audio.Play();
        Time.timeScale = 1.0f;
        Pause.SetActive(false);
        GameIsPaused = false;
    }

    public void BackToMenu()
    {
        audio.Play();
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Choosing");
        //GameIsPaused = false;
    }

    public void QuitGame()
    {
        audio.Play();
        Application.Quit();
    }
}
