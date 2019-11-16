using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterMove : MonoBehaviour
{
    #region Fields

    private Vector2 startingPoint;

    [SerializeField]
    private Vector2 endingPoint;

    [SerializeField]
    private float travelTime;

    private bool isMoving;
    private bool goingForwards;
    private float distancePerFrame;

    private Vector3 spacePerFrame;

    private MakeBlock mb;
    private GameObject thisBlock;

    private float distance;

    #endregion Fields

    #region Properties



    #endregion Properties

    // Start is called before the first frame update
    void Start()
    {
        // Grab reference to the makeBlock script.
        mb = this.gameObject.GetComponent<MakeBlock>();
        thisBlock = mb.ThisBlock;

        startingPoint = this.gameObject.transform.position;

        // Set starting movement.
        isMoving = true;
        goingForwards = true;

        // Set out movement variables and make calculations.
        distance = Vector2.Distance(startingPoint, endingPoint);
        distancePerFrame = distance / travelTime;
        spacePerFrame = (startingPoint - endingPoint) * distancePerFrame;
    }

    // Update is called once per frame
    void Update()
    {
        // First, check if the block is active or not to determine if we're moving.
        isMoving = !thisBlock.activeSelf;

        if (isMoving)
        {
            if (goingForwards)
            {
                this.gameObject.transform.position += spacePerFrame;
            }
            else
            {
                this.gameObject.transform.position -= spacePerFrame;
            }
        }

        // Check if the object needs to switch directions.
        if (this.gameObject.transform.position.x == startingPoint.x && this.gameObject.transform.position.y == startingPoint.y)
        {
            goingForwards = true;
        }

        if (this.gameObject.transform.position.x == endingPoint.x && this.gameObject.transform.position.y == endingPoint.y)
        {
            goingForwards = false;
        }

        // Move the associated block with this letter.
        thisBlock.transform.position = this.gameObject.transform.position;
    }
}
