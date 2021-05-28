using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check_ground : MonoBehaviour
{
    private player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerController>();
    }

    // Update is called once per frame
    void OnCollisionStay2D(Collision2D col)
    {
        player.grounded = true;
    }
    void OnCollisionExit2D(Collision2D col)
    {
        player.grounded = false;
    }
}
