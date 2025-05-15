using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class collect : MonoBehaviour
{
    public Text score;
    public int collected;


    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        collected = 0;
    }

    private void Update()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        score.text = "x " + collected.ToString();
    }
}
