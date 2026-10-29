using System;
using UnityEngine;

public class SkeletextScript : MonoBehaviour
{
    static public GameObject textbox;
    static public bool inRange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textbox = gameObject;
        textbox.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        //if (inRange == true)
        //{
        //    textBox.SetActive(true);
        //}
        //else
        //{
        //    textBox.SetActive(false);
        //}
    }
}

    