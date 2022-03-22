using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject text;
    public int total;

    private GameObject[] coins;
    private int num;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<Text>().text = num.ToString();
        coins = GameObject.FindGameObjectsWithTag("Collections");
        num = total - coins.Length;
    }
}
