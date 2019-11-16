using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseControl : MonoBehaviour
{
    #region fields
    private bool pressed;
    [SerializeField]
    private GameObject canvas;
    private bool active;
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
        canvas.SetActive(false);
        pressed = false;
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(pressed == true)
        {
            canvas.SetActive(active);
            pressed = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.SetActive(active);
            active = !active;
        }

        if(canvas.activeSelf == true)
        {
            active = false;
        }
        else
        {
            active = true;
        }
    }
}
