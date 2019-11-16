using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelWin : MonoBehaviour
{

    #region Fields
    private bool active;
    [SerializeField]
    private string target;
    [SerializeField]
    private GameObject player;
    #endregion Fields

    #region Properties

    #endregion Properties

    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true)
        {
            SceneManager.LoadScene(target);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        active = true;
    }
}
