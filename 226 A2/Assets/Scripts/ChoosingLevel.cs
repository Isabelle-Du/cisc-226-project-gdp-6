using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoosingLevel : MonoBehaviour
{
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void PlayTeaching()
    {
        audio.Play();
        SceneManager.LoadScene("Teaching");
    }

    public void PlayLevelI()
    {
        audio.Play();
        SceneManager.LoadScene("Level I");
    }

    public void PlayLevelII()
    {
        audio.Play();
        SceneManager.LoadScene("Level II");
    }

    public void PlayLevelIII()
    {
        audio.Play();
        SceneManager.LoadScene("Level III");
    }

    public void Back()
    {
        audio.Play();
        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
