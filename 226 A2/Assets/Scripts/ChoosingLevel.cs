using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoosingLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayTeaching()
    {
        SceneManager.LoadScene("Teaching");
    }

    public void PlayLevelI()
    {
        SceneManager.LoadScene("Level I");
    }

    public void PlayLevelII()
    {
        SceneManager.LoadScene("Level II");
    }

    public void PlayLevelIII()
    {
        SceneManager.LoadScene("Level III");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
