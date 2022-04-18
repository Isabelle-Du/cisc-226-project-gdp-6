using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour
{
    private GameObject[] coins;
    private int num;
    void Update()
    {

        coins = GameObject.FindGameObjectsWithTag("Collections");
        num = coins.Length;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(num == 3)
            {
                SceneManager.LoadScene("Finish");
            }
            else if(num == 2)
            {
                SceneManager.LoadScene("Finish I");
            }
            else if(num == 1)
            {
                SceneManager.LoadScene("Finish II");
            }
            else if(num == 0)
            {
                SceneManager.LoadScene("Finish III");
            }
        }
    }
}
