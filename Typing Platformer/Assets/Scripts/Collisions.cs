using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    #region Fields
    [SerializeField]
    private GameObject[] blocks;
    #endregion Fields

    #region Properties
    public GameObject[] Blocks
    {
        get { return blocks; }
        set { blocks = value; }
    }
    #endregion Properties
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collided = collision.gameObject;
        //collided.GetComponent<>
    }
}
