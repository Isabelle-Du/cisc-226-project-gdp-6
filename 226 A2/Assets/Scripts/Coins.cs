using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colloections : MonoBehaviour
{
    public GameObject coin;
    private GameObject player;
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject == player)
        {
            GameObject.Destroy(coin);
            num += 1;
        }
    }
}
