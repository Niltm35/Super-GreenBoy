using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdata()
    {
        float h = Input.GetAxis("Horizontal");
    }
}
