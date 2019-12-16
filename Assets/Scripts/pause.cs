using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{

    public static bool Active;
    Canvas canvas;

    //Lo que hace este script es que si apretamos la tecla esc 

    // Use this for initialization
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        Active = false;
        Time.timeScale = (Active) ? 0 : 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Active = !Active;
            canvas.enabled = Active;
            Time.timeScale = (Active) ? 0 : 1f;
        }
    }
}