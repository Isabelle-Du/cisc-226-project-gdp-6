using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawn;

    private Transform playerTransForm;
    // Start is called before the first frame update
    void Start()
    {
        playerTransForm = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        respawn.position = playerTransForm.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
