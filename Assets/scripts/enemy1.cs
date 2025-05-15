using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{
    private float speed;
    public float time;
    bool goup;
    public Animator anim;

    void Start()
    {
        speed = 5;
        goup = true;
        time = 0;
    }

    void Update()
    {
        if (goup == true)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            anim.Play("1left");
        }
        else if (goup == false)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            anim.Play("1right");
        }

        if (goup == true && time < 1)
        {
            goup = false;
            time = 4;
        }
        else if (goup == false && time < 1)
        {
            goup = true;
            time = 4;
        }

        time -= 1 * Time.deltaTime;
        //Debug.Log(time);
    }
}
