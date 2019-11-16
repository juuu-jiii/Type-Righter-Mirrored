using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Fields
    [SerializeField]
    private Vector2 pos;
    [SerializeField]
    private float grav;
    //[SerializeField]
    //private float accY;
    [SerializeField]
    private float velY;
    [SerializeField]
    private float velX;
    [SerializeField]
    private float jumpBurst;
    [SerializeField]
    private bool resting;
    #endregion Fields
    // Start is called before the first frame update
    void Start()
    {
        grav = -6f;
        velX = 1f;
        jumpBurst = 7f;
        //temporary
        resting = true;
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
            pos.x -= velX * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += velX * Time.deltaTime;
        }
        else
        {
            velX = 0;
        }
        if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && resting )
        {
            velY = jumpBurst;
            resting = false;
        }

        Gravity();
        pos += new Vector2(velX, velY);
    }



    void Gravity()
    {
        velY -= grav * Time.deltaTime;


    }

    public void Landed()
    {
        velY = 0;
        resting = true;
    }

}
