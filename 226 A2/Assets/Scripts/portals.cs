using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portals : MonoBehaviour
{
    public Transform backDoor;

    private bool isDoor;
    private Transform playerTransForm;
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
        if(Input.GetKeyDown("e"))
        {
            if(isDoor)
            {
                audio.Play();
                playerTransForm.position = backDoor.position;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isDoor = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isDoor = false;
        }
    }
}
