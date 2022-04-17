using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public float roundTime;
    public Transform por1;
    public Transform por2;

    private float time;
    private Vector2 start;
    private Vector2 destination;
    private bool Trans = false;
    // Start is called before the first frame update
    void Start()
    {
        time = roundTime;
        start = por1.position;
        destination = por2.position;
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
            if(Trans == false)
            {
                por1.position = destination;
                por2.position = start;
                roundTime = time;
                Trans = true;
            }
            else if(Trans == true)
            {
                por1.position = start;
                por2.position = destination;
                roundTime = time;
                Trans = false;
            }
            
        }
    }
}
