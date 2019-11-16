using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Fields

    private Vector2 pos;

    private float grav;
    //[SerializeField]
    //private float accY;

    private float velY;

    private float velX;

    private float jumpBurst;

    private bool resting;
    private int counter = 15;
    #endregion Fields
    // Start is called before the first frame update
    void Start()
    {
        grav = 0.0001f;
        velX = 1f;
        jumpBurst = 10f;
        //temporary
        resting = true;
        pos = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {


        Movin();

        this.gameObject.transform.position = pos;
    }

    void Movin()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= velX;
            Debug.Log("Left");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += velX;
            Debug.Log("Right");
        }
        else
        {
            velX = 0;
        }
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && resting )
        {
            velY = jumpBurst;
            resting = false;
            Debug.Log("Jump");
        }
        else
        {
            velY = 0f;
        }
        //if(!resting)
        //Gravity();
        pos.y += velY;
        transform.position = pos;
        //Debug.Log(velY);
    }



    void Gravity()
    {
        velY -= (grav + Time.deltaTime)/5f;

    }

    public void Landed()
    {
        velY = 0;
        resting = true;
        Debug.Log("Landed");
    }

}
