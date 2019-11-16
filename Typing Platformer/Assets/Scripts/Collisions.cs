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
        Debug.Log(collided);
        PrefabInfo pre = collided.GetComponent<PrefabInfo>();

        switch (pre.Type)
        {
            case PrefabType.Block:
                {
                    Player.gameObject.GetComponent<PlayerMovement>().Landed(collided);
                }
                break;
            case PrefabType.Spike:
                {
                    Player.gameObject.GetComponent<PlayerMovement>().Landed(collided);
                    SceneManager.LoadScene("GameOver");

                }
                break;
            case PrefabType.Goal:
                {
                    Player.gameObject.GetComponent<PlayerMovement>().Landed(collided);
                    levelCompleteCanvas.SetActive(true);
                }
                break;
            case PrefabType.Solid:
                {
                    Player.gameObject.GetComponent<PlayerMovement>().Landed(collided);
                    Debug.Log("landed");
                }
                break;
        }
    }
}
