using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PrefabType { Block, Goal, Spike, Letter, Solid}

public class PrefabInfo : MonoBehaviour
{
    #region Fields

    [SerializeField]
    private PrefabType type;

    #endregion Fields

    #region Properties

    /// <summary>
    /// Gets or sets what type of object this item is.
    /// </summary>
    public PrefabType Type
    {
        get
        {
            return type;
        }
        set
        {
            type = value;
        }
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
}
