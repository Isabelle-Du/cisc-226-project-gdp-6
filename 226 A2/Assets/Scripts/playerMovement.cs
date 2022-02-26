using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerMovement : MonoBehaviour
{
    public float speed;
    public float jumpSpeend;

    private Rigidbody2D myRigidbody;
    private BoxCollider2D ground;
    private bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        ground = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if(Input.GetButtonDown("Jump"))
        {
            if(ground.IsTouchingLayers(LayerMask.GetMask("Ground")))
            {
                Vector2 jumpVel = new Vector2(0.0f, jumpSpeend);
                myRigidbody.velocity = Vector2.up * jumpVel;
            }

        }
    }
}
