using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class testBright : MonoBehaviour
{
    public Slider Bright;
    public Material Mat;
    bool stat = true;
    int progress;

    void Start()
    {
        progress = -100;
        Bright.value = progress;
        Mat.SetFloat("_BrightnessParam", progress);
    }

    void FixedUpdate()
    {
        if (stat == true)
        {
            progress++;
            Bright.value = progress;
            Mat.SetFloat("_BrightnessParam", progress);
            if (progress == 100) stat = !stat;
        }
        if (stat == false)
        {
            progress--;
            Bright.value = progress;
            Mat.SetFloat("_BrightnessParam", progress);
            if (progress == -100) stat = !stat;
        }
    }
    private void OnApplicationQuit()
    {
        Mat.SetFloat("_BrightnessParam", 0);
        Bright.value = 0;
    }
}
