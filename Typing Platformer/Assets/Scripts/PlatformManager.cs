using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    #region Fields
    [SerializeField]
    private GameObject[] platforms;
    [SerializeField]
    private PlatformBehavior ps;
    #endregion Fields
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkPlatforms();
    }

    void checkPlatforms()
    {
        for (int i = 0; i < platforms.Length; i++)
        {
            ps = platforms[i].GetComponent<PlatformBehavior>();
        }
    }
}
