using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontroller : MonoBehaviour
{

    private bool hleft;
    private bool jump;
    private bool hright;
    private Animator anim;


    void Start()
    {
        jump = false;
        hright = true;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
     
        //input directions
        if (Input.GetKey(KeyCode.D)){
            hright = true;
            hleft = false;
        }

        else if (Input.GetKey(KeyCode.A)){
            hleft = true;
            hright = false;
        }

        //idle anims
        if (hright == true && jump == false && !(Input.GetKey(KeyCode.A)) && !(Input.GetKey(KeyCode.D)))
        {
            anim.Play("iright");
        }

        if (hleft == true && jump == false && !(Input.GetKey(KeyCode.A)) && !(Input.GetKey(KeyCode.D)))
        {
            anim.Play("ileft");
        }

        //walk anims
        if (hleft == true && (Input.GetKey(KeyCode.A)) && !jump == true)
        {
            anim.Play("walkleft");
        }

        else if (hright == true && (Input.GetKey(KeyCode.D)) && !jump == true)
        {
            anim.Play("walkright");
        }

        //check for jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }

        //jump anims
        if (hright == true && jump == true)
        {
            anim.Play("jright");
        }

        if (hleft == true && jump == true)
        {
            anim.Play("jleft");
        }
    }

    private void OnCollisionEnter2D(Collision2D coll) {

        //reset jump state
        if (coll.gameObject.CompareTag("ground"))
        {
            jump = false;
        }

    }
}
