using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGoalMenu : MonoBehaviour
{

    #region Fields

    [SerializeField]
    private GameObject levelCompleteCanvas;
    [SerializeField]
    private GameObject player;
    private Renderer playerSpriteRenderer;
    private Renderer levelGoalSpriteRenderer;
    //private bool activated;

    #endregion Fields

    #region Properties
    #endregion Properties

    // Start is called before the first frame update
    void Start()
    {
        //activated = false;
        playerSpriteRenderer = player.transform.GetChild(0).GetComponent<Renderer>();
        levelGoalSpriteRenderer = gameObject.transform.GetChild(0).GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerSpriteRenderer.bounds.Intersects(levelGoalSpriteRenderer.bounds)){
            //activated = true;
            //OR
            canvas.SetActive(true);
        }
        //if(activated){
            //canvas.SetActive(true);
        //}
    }
}
