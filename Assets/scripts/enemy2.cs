using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour
{

    public float speed;
    public float time;
    bool goup;
    public Animator anim;

    void Start()
    {
        speed = 4;
        goup = true;
        time = 0;
    }

    void Update()
    {
        if (goup == true)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            anim.Play("2left");
        }
        else if (goup == false)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            anim.Play("2right");
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

        time -= time * Time.deltaTime;
        //Debug.Log(time);
    }
}
