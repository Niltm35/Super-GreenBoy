using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public bool grounded;

    private bool jump;
    private bool doubleJump;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void click()
    {
        if (grounded)
        {
            doubleJump = true;
        }

        if (true)
        {
            if (grounded)
            {
                jump = true;
                doubleJump = true;
            }
            else if (doubleJump)
            {
                jump = true;
                doubleJump = false;
            }
        }
    }
}
