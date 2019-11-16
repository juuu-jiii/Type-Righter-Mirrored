using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hIDE : MonoBehaviour
{
    private int count;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        count = 100;
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (count >= 0)
            count--;
        else
        {
            sr.sortingOrder = -4;
        }
            

        
    }
}
