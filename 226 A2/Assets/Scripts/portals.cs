using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portals : MonoBehaviour
{
    public Transform backDoor;

    private bool isDoor;
    private Transform playerTransForm;
    // Start is called before the first frame update
    void Start()
    {
        playerTransForm = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            if(isDoor)
            {
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
