﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopupButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        if (GameData.ReturnTitle == true)
        {
            GameData.ReturnTitle = false;
            GameData.PlayerLimit = -1;
            SceneManager.LoadScene("Title");
        }
        this.transform.parent.gameObject.SetActive(false);

    }
}
