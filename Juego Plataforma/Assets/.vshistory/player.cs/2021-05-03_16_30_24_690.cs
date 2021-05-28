using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rb2d.AddForce(Vector2.right * speed * h);
        rb2d.AddForce(Vector2.up * speed * y);

        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x,-maxSpeed,maxSpeed);

        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);

        Debug.Log(rb2d.velocity.x);
    }
}
