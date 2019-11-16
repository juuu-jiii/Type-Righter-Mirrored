using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{
    #region Fields
    [SerializeField]
    private KeyCode key;
    [SerializeField]
    private bool active;
    [SerializeField]
    private int counter;
    #endregion Fields
    // Start is called before the first frame update
    void Start()
    {
        counter = 180;
    }

    // Update is called once per frame
    void Update()
    {
        if( active == true)
        Timer();
    }

    void Timer()
    {
        counter--;
        if(counter <= 0)
        {
            active = false;
            counter = 180;
        }
    }
}
