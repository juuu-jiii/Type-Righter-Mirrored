using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    #region Fields
    [SerializeField]
    private GameObject[] blocks;

    [SerializeField]
    private GameObject levelCompleteCanvas;
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
        for (int i = 0; i > blocks.Length; i++)
        {

        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collided = collision.gameObject;
        Debug.Log("I collided!");
        PrefabType collidedType = collided.GetComponent<PrefabInfo>().Type;
        
        if(collidedType == PrefabType.Solid)
            Debug.Log("landed");
        switch (collidedType)
        {
            case PrefabType.Block:
                {
                    this.gameObject.GetComponent<Rigidbody>().useGravity = false;
                }
                break;
            case PrefabType.Spike:
                {
                    this.gameObject.GetComponent<PlayerMovement>().Landed();
                    SceneManager.LoadScene("GameOver");

                }
                break;
            case PrefabType.Goal:
                {
                    this.gameObject.GetComponent<PlayerMovement>().Landed();
                    levelCompleteCanvas.SetActive(true);
                }
                break;
            case PrefabType.Solid:
                {
                    this.gameObject.GetComponent<PlayerMovement>().Landed();
                    Debug.Log("landed");
                }
                break;
        }
    }
}
