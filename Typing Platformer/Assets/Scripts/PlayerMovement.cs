using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Fields

    private Vector3 position;
    private Vector3 velocity;

    private bool isJumping;
    private bool isVerticalDecay;

    [SerializeField]
    private float moveSpeed = 0.1f;

    #endregion Fields

    #region Properties

    /// <summary>
    /// Gets or sets the jumping state of this object.
    /// </summary>
    public bool IsJumping
    {
        get
        {
            return isJumping;
        }
        set
        {
            isJumping = value;
        }
    }

    /// <summary>
    /// Gets or sets the state of the vertical velocity's decay.
    /// </summary>
    public bool IsVerticalDecay
    {
        get
        {
            return isVerticalDecay;
        }
        set
        {
            isVerticalDecay = value;
        }
    }

    #endregion Properties

    // Start is called before the first frame update
    void Start()
    {
        position = this.gameObject.transform.position;
        velocity = Vector3.zero;
        isJumping = false;
        isVerticalDecay = false;
    }

    // Update is called once per frame
    void Update()
    {
        position = this.gameObject.transform.position;

        // Listen out for left or right inputs
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x = -1 * moveSpeed;
            Debug.Log("Left");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x = moveSpeed;
            Debug.Log("Right");
        }

        // If neither inputs are pressed, decay horizontal movement
        if (Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.RightArrow) == false)
        {
            // Decay the speed based on which direction the player is moving in.
            velocity.x -= velocity.x / 4;

            if (Mathf.Abs(velocity.x) <= 0.001f)
            {
                velocity.x = 0;
            }
        }

        // Listen for jump input from up arrow or space bar.
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Jump");
            if (isJumping == false)
            {
                isJumping = true;
                velocity.y += 1;
            }
        }

        // Let the jump velocity decay
        if (isVerticalDecay)
        {
            velocity.y -= velocity.y / 4;
            if (velocity.y <= 0.001f)
            {
                velocity.y = 0;
            }
        }
        else
        {
            velocity.y -= velocity.y / 4;
            if (velocity.y <= 0.001f)
            {
                isVerticalDecay = true;
            }
        }

        // Update this script's position, then update the GameObject's position.
        position += velocity;
        this.gameObject.transform.position = position;
    }
}
