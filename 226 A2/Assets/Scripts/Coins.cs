using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public GameObject coin;

    private Transform playerTransForm;
    private bool isCoin;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        playerTransForm = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isCoin)
        {
            GameObject.Destroy(coin);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audio.Play();
            isCoin = true;
        }
    }

}
