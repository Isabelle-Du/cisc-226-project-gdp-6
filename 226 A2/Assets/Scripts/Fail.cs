using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fail : MonoBehaviour
{
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Choosing");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
