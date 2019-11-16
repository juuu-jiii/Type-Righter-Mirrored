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
    private int counter = 10;
    private Vector2 temPos;
    #endregion Fields
    // Start is called before the first frame update
    void Start()
    {
        grav = 0.0001f;
        velX = 1f;
        jumpBurst = 1f;
        //temporary
        resting = true;
        pos = new Vector2(-15.23f, -10.24f);
        temPos = new Vector2(0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        Movin();
        
    }

    void Movin()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            temPos.x -= velX;
            Debug.Log("Left");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            temPos.x += velX;
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
        else if(!resting && counter > 0)
        {
            velY = jumpBurst;//- (float)(counter/10f);
            counter--;
        }
        else
        {
            velY = 0f;
        }
        //if(!resting)
        //Gravity();
        pos.y += velY;
        pos += temPos;
        transform.position = pos;
        //Debug.Log(velY);
        temPos = new Vector2(0f, 0f);
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
