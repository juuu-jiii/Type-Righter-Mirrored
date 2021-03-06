﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBlock : MonoBehaviour
{
    #region Fields

    [SerializeField]
    private KeyCode letter;

    private TextMesh tm;

    private bool isListening;

    private float count;

    [SerializeField]
    private float timeActive = 5f;

    [SerializeField]
    private GameObject blockPrefab;

    private GameObject thisBlock;

    #endregion Fields

    #region Properties

    /// <summary>
    /// Gets or sets what letter this letter object should be.
    /// </summary>
    public KeyCode Letter
    {
        get
        {
            return letter;
        }
        set
        {
            letter = value;
        }
    }

    /// <summary>
    /// Gets the block spawned by this letter.
    /// </summary>
    public GameObject ThisBlock
    {
        get
        {
            return thisBlock;
        }
    }

    #endregion Properties

    // Start is called before the first frame update
    void Start()
    {
        tm = this.gameObject.GetComponentInChildren<TextMesh>();
        tm.text = letter.ToString().ToUpper();

        isListening = true;
        count = 0;

        thisBlock = Instantiate(blockPrefab, this.gameObject.transform.position, Quaternion.identity);
        thisBlock.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        tm.text = letter.ToString().ToUpper();

        // If there is no block yet, and the proper character is selected, then make the block.
        if (Input.GetKey(letter) && isListening)
        {
            isListening = false;
            thisBlock.SetActive(true);
            
        }

        // Up the count variable if the block is active.
        if (!isListening)
        {
            count += Time.deltaTime;
        }

        // Check if the block should be destroyed or not.
        if (count >= timeActive)
        {
            thisBlock.SetActive(false);
            count = 0;
            isListening = true;
        }
    }
}
