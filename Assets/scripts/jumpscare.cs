using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class jumpscare : MonoBehaviour
{
    public VideoPlayer jsvid;
    public bool playing;

    void Update()
    {
        jsvid.loopPointReached += stop;
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.CompareTag("jumpscare"))
        {
            jsvid.Play();
            Destroy(coll.gameObject);     
        }
    }
    void stop(UnityEngine.Video.VideoPlayer jsvid)
    {
        jsvid.Stop();
    }
}
