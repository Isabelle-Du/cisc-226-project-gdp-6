using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public GameObject text;
    public int TotalTime;

    private int time;
    // Start is called before the first frame update
    void Start()
    {   
        time = TotalTime;
        StartCoroutine(Time());
    }

    IEnumerator Time()
    {
        while (TotalTime >= 0)
        {
            text.GetComponent<Text>().text = TotalTime.ToString();
            yield return new WaitForSeconds(1);
            TotalTime--;
        }
    }

    // Update is called once per frame
    void Update()
    {
       if (TotalTime == 0)
        {
            TotalTime = time;
        }
    }
}
