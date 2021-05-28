using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour
{
    public GameObject follow;
    Text puntuacion;

    // Start is called before the first frame update
    void Start()
    {
        puntuacion = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float score = follow.transform.position.x;
        int score_int = (int)score+27;

        if (score_int<=0)
        {
            score_int = 0;
        }

        puntuacion.text = "Score: " + score_int;
    }
}
