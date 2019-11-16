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

    #endregion Fields

    #region Properties
    #endregion Properties

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            string previousScene = PlayerPrefs.GetString("previousScene");
            SceneManager.LoadScene(previousScene);
        }
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

    public void RetryLevel(){
        string previousScene = PlayerPrefs.GetString("previousScene");
        SceneManager.LoadScene(previousScene);
    }

}
