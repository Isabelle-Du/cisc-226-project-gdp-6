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
    private Animator anim;
    private AudioSource jump;
    private AudioSource walk;
    private AudioSource coins;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        ground = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        var audio = GetComponents(typeof(AudioSource));
        jump = (AudioSource)audio[0];
        coins = (AudioSource)audio[1];
        walk = (AudioSource)audio[2];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            anim.SetInteger("RunningState", -1);
        }
        else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            anim.SetInteger("RunningState", 1);           
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown("a"))
        {
            walk.Play();
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp("a"))
        {
            walk.Stop();
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown("d"))
        {
            walk.Play();
        }
        if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp("d"))
        {
            walk.Stop();
        }
        if(Input.GetButtonDown("Jump"))
        {
            if(ground.IsTouchingLayers(LayerMask.GetMask("Ground")))
            {
                Vector2 jumpVel = new Vector2(0.0f, jumpSpeend);
                myRigidbody.velocity = Vector2.up * jumpVel;
                anim.SetInteger("RunningState", 2);
                jump.Play();
            }

        }

        if(Mathf.Abs(myRigidbody.velocity.y) == 0.0f && Mathf.Abs(myRigidbody.velocity.x) == 0.0f)
        {
            anim.SetInteger("RunningState", 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collections"))
        {
            coins.Play();
        }
    }
}
