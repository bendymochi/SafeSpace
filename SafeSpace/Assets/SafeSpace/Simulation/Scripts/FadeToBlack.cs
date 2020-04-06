﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeToBlack : MonoBehaviour
{
    public Animator animator;
    private int levelToLoad;

    public void FadeToNextLevel() {
        FadeTo(SceneManager.GetActiveScene().buildIndex + 1); 
    }

    public void FadeTo(int levelIndex) {
        levelToLoad = levelIndex;
        animator.SetTrigger("FadeToBlack");
        Debug.Log("fadeto triggered");
    }

    public void OnFadeComplete() {
        SceneManager.LoadScene(levelToLoad);
    }
}