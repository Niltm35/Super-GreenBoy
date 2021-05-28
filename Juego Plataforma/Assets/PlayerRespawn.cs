using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    GameObject position;
    public float positionX;
    public float positionY;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Respawn")
        {
            positionX = position.transform.position.x;
            positionY = position.transform.position.y;
        }
        
        if (collision.gameObject.tag == "Enemy")
        {
            StartCoroutine(DieAndRespawn(positionX,positionY));
        }        
    }

    void Update()
    {
        if (transform.position.y < -5)
        {
            StartCoroutine(DieAndRespawn(positionX, positionY));
        }
    }

    IEnumerator DieAndRespawn(float positionX, float positionY)
    {
        GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(0f);
        transform.position = new Vector3(positionX, positionY, 0.0f);
        transform.rotation = Quaternion.identity;
        GetComponent<Renderer>().enabled = true;
    }
}
