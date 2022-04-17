using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float roundTime;

    private float time;
    private Transform playerTransForm;

    // Start is called before the first frame update
    void Start()
    {
        time = roundTime;
        playerTransForm = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Count();
    }

    void Count()
    {
        if(roundTime > 0)
        {
            roundTime -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("Fail");
            roundTime = time;
        }
    }
}
