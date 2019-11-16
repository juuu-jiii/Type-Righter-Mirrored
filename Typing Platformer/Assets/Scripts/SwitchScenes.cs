using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScenes : MonoBehaviour
{

    #region Fields

    [SerializeField]
    private Scene scene;

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

    }

    void OnClick(){
        SceneManager.LoadScene (sceneName:"TitleScene");
    }

}
