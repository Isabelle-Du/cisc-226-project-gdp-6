using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
    public GameObject fog;
    private bool Istouched;

    private Transform playerTransForm;
    // Start is called before the first frame update
    void Start()
    {
        playerTransForm = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Istouched)
        {
            fog.GetComponent<Disappear>().enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Istouched = true;          
        }
    }
}
