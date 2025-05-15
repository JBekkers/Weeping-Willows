using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitgame : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        //  quit game
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
