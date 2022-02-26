using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pause : MonoBehaviour
{
    public GameObject PauseUI;
    public static bool GameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused == false)
            {
                PauseUI.SetActive(true);
                Time.timeScale = 0.0f;
                GameIsPaused = true;
            }
            else if(GameIsPaused == true)
            {
                PauseUI.SetActive(false);
                Time.timeScale = 1.0f;
                GameIsPaused = false;
            }

        }
    }
    
}
