﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MusicLoader : MonoBehaviour
{
    public GameObject selectMessage;
    public GameObject musicPanel;
    public GameObject nextPanel;
    public GameObject sliderObject;

    public string[] trackNames;

    public string messageBeginning;
    public string messageNoneSelected;

    private bool selected = false;
    private int selectedMusic;
    private Text messageShown;
    private Slider slider;

    public void Start()
    {
        slider = sliderObject.GetComponent<Slider>();
        messageShown = selectMessage.GetComponent<Text>();
        messageShown.text = messageNoneSelected;
    }

    public void LoadNext()
    {
        nextPanel.SetActive(true);
        musicPanel.SetActive(false);
    }

    public void UpdateMusic(int id)
    {
        if (selected && id == selectedMusic)
        {
            selected = false;
            messageShown.text = messageNoneSelected;
        }
        else
        {
            selectedMusic = id;
            selected = true;
            messageShown.text = messageBeginning + trackNames[id];
        }
    }

    public void LowerVolume()
    {
        float currentValue = slider.value;
        slider.value = Mathf.Max(0f, slider.value - 0.1f);
    }

    public void IncreaseVolume()
    {
        float currentValue = slider.value;
        slider.value = Mathf.Min(1f, slider.value + 0.1f);
    }
}