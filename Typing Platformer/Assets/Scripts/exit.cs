using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    #region fields
    private bool pressed;
    private float delay;
    #endregion fields

    #region properties
    public bool Pressed
    {
        set
        {
            pressed = !pressed;
        }
    }
    #endregion properties


    // Start is called before the first frame update
    void Start()
    {
        pressed = false;
        delay = .5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (pressed == true)
        {
            delay -= Time.deltaTime;
            if (delay <= 0)
            {
                Application.Quit();
            }
        }

    }
}
