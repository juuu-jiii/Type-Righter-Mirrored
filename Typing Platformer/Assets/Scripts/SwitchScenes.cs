using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScenes : MonoBehaviour
{

    #region Fields

    [SerializeField]
    private string target;
    //private bool activated;

    #endregion Fields

    #region Properties
    #endregion Properties

    // Start is called before the first frame update
    void Start()
    {
        //activated = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Player.bounds.Intersects(bounds)){
            //activated = true;
            //OR
            //Canvas stuff is enabled
        //}
        //if(activated){
            //Canvas.SetActive(true);
        //}
    }

    public void NextScene(){
        SceneManager.LoadScene(target);
    }

    public void SwitchToMainMenu(){
        SceneManager.LoadScene("TitleScene");
    }

    public void QuitGame(){
        Application.Quit();
    }

}
