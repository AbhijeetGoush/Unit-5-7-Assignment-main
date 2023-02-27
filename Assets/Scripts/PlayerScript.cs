using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    bool touchingplatform;
    Animator anim;
    HelperScript helper;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        touchingplatform = false;
        helper = GetComponent<HelperScript>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = rb.velocity;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = 7;
            anim.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -7;
            anim.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.UpArrow) && touchingplatform == true)
        {
            vel.y = 7;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            vel.x = 0;
            anim.SetBool("Run", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            vel.x = 0;
            anim.SetBool("Run", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = 7;
            anim.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -7;
            anim.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.W) && touchingplatform == true)
        {
            vel.y = 7;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            vel.x = 0;
            anim.SetBool("Run", false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            vel.x = 0;
            anim.SetBool("Run", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            helper.FlipObject(true);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            helper.FlipObject(false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            helper.FlipObject(true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            helper.FlipObject(false);
        }
        rb.velocity = vel;
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            touchingplatform = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            touchingplatform = false;
        }
    }
}
