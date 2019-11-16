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
    private GameObject player;
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
        PrefabType pre = collided.GetComponent<PrefabInfo>().Type;
        switch(pre)
        {
            case PrefabType.Block:
                {
                    player.GetComponent<PlayerMovement>().Landed();
                }
                break;
            case PrefabType.Spike:
                {
                    player.GetComponent<PlayerMovement>().Landed();
                    SceneManager.LoadScene("GameOver");

                }
                break;
            case PrefabType.Goal:
                {
                    player.GetComponent<PlayerMovement>().Landed();
                }
                break;
        }
    }
}
