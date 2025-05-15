using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secret : MonoBehaviour
{
    public GameObject platform;
  
     private void OnTriggerEnter2D(Collider2D col) { 
        if (col.gameObject.CompareTag("Player"))
        {
            Instantiate(platform, new Vector3(81.5F , 1.11F, 0), Quaternion.identity);
            Destroy(gameObject);
        }
       
    }
}
