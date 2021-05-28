using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float maxSpeed = 5f;
    public float speed = 2f;
    public bool grounded;
    public float jumpPower = 6.5f;

    private Rigidbody2D rb2d;
    private Animator anim;
    private bool jump;
    private bool doubleJump;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Grounded", grounded);

        if (grounded)
        {
            doubleJump = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded)
            {
                jump = true;
                doubleJump = true;
            }
            else
            {
                jump = true;
                doubleJump = false;
            }
        }
    }

    public void FixedUpdate()
    {
        Vector3 fixedVelocy = rb2d.velocity;
        //fixedVelocy.x = 0f;
        //if (grounded)
        //{
        //    rb2d.velocity = fixedVelocy;
        //}
        float h = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rb2d.AddForce(Vector2.right * speed * h);
        //rb2d.AddForce(Vector2.up * speed * y);

        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x,-maxSpeed,maxSpeed);
        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

        if (h > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        //if (h < 0.1f)
        //{
        //    transform.localScale = new Vector3(-1f, 1f, 1f);
        //}
        if (jump && grounded)
        {
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
            //doubleJump = true;

        }
        //else if(jump && doubleJump)
        //{
        //    rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        //    jump = false;
        //    doubleJump = false;
        //}
        Debug.Log(rb2d.velocity.x);
    }

    
}
