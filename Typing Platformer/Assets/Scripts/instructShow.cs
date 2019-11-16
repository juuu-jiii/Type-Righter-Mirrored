using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instructShow : MonoBehaviour
{
    #region field
    [SerializeField]
    private GameObject instrucitons;
    private bool pressed; 
    #endregion field

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
        instrucitons.SetActive(false);
        pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(pressed == true)
        {
            instrucitons.SetActive(true);
            pressed = false;
        }

        if(instrucitons.activeSelf == false)
        {
            pressed = false;
        }
    }
}
