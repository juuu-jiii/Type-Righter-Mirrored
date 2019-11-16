using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    #region Fields

    [Header("This is a header")]
    [SerializeField]
    private float timeToComplete;

    private float count;

    #endregion Fields

    #region Properties



    #endregion Properties


    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            GameObject circle = this.gameObject;
            circle.transform.position = new Vector2(circle.transform.position.x + 0.2f, circle.transform.position.y);
            GameObject newCircle = Instantiate(circle, new Vector2(0.3f, 0.4f), Quaternion.identity);

            Destroy(newCircle);

            
        }

        count += Time.deltaTime;

        if (count >= timeToComplete)
        {
            count = 0;

            GameObject circle = this.gameObject;
            circle.transform.position = new Vector2(circle.transform.position.x, circle.transform.position.y - 0.2f);
        }


    }
}
