using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject[] buttons;
    public GameObject selectionBox;
    public GameObject selectionArrow;
    int selected = 1;

    // Start is called before the first frame update
    void Start()
    {
        toggleSelection();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            toggleSelection();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {

            if (selected == 0)
            {
                SceneManager.LoadScene("lvl1");
            }
            else
            {
                SceneManager.LoadScene("htp");
            }
        }

        //  quit game
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }


    }

    void toggleSelection()
    {
        if (selected == 0)
        {
            selected = 1;
        }
        else
        {
            selected = 0;
        }
        selectionBox.transform.position = buttons[selected].transform.position;
        selectionArrow.transform.position = buttons[selected].transform.position;
    }
}
