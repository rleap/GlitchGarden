﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    [SerializeField] int loadDelay = 5;
    int currentSceneIndex;

    // Use this for initialization
    void Start () {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0) 
        {
            StartCoroutine(WaitForTime());
        }

	}

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(loadDelay);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadLoseScene()
    {
        SceneManager.LoadScene("03 Lose Scene");
    }
}
