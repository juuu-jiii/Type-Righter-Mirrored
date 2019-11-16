using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
    #region Fields

    [SerializeField]
    private GameObject levelCompleteCanvas;

    #endregion Fields

    #region Properties

    #endregion Properties

    // Start is called before the first frame update
    void Start()
    {
        levelCompleteCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collided = collision.gameObject;
        //Debug.Log("I collided!");
        PrefabInfo collidedType = collided.GetComponent<PrefabInfo>();
        PlayerMovement movement = this.gameObject.GetComponent<PlayerMovement>();

        switch (collidedType.Type)
        {
            case PrefabType.Block:
                {
                    movement.IsJumping = false;
                    //Debug.Log("Block!");
                }
                break;
            case PrefabType.Solid:
                {
                    movement.IsJumping = false;
                    //Debug.Log("solid");
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
