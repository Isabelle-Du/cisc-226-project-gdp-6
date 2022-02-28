using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
    public GameObject GroundMid;
    public GameObject Fog1;

    public GameObject GroundLeft;
    public GameObject Fog2;

    public GameObject GroundFinish;
    public GameObject Fog3;

    public GameObject GroundRight;
    public GameObject Fog4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject == GroundMid)
        {
            GameObject.Destroy(Fog1);
        }
        else if(other.gameObject == GroundLeft)
        {
            GameObject.Destroy(Fog2);
        }
        else if(other.gameObject == GroundFinish)
        {
            GameObject.Destroy(Fog3);
        }
        else if(other.gameObject == GroundRight)
        {
            GameObject.Destroy(Fog4);
        }
    }
}
