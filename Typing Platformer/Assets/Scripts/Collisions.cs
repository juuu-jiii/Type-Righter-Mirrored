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

    [SerializeField]
    private GameObject Player;
    #endregion Fields
    //
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
        PlayerMovement movement = this.gameObject.GetComponent<PlayerMovement>();

        if(collidedType == PrefabType.Solid)
            Debug.Log("landed");
        switch (collidedType)
        {
            case PrefabType.Block:
                {
                    movement.IsJumping = false;
                    Debug.Log("Block!");
                }
                break;
            case PrefabType.Spike:
                {
                    PlayerPrefs.SetString("previousScene", SceneManager.GetActiveScene().name);
                    SceneManager.LoadScene("GameOver");
                }
                break;
            case PrefabType.Goal:
                {
                    levelCompleteCanvas.SetActive(true);
                }
                break;
        }
    }
}
