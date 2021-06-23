using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class testOpacity : MonoBehaviour
{
    public Slider Opacity;
    public Material Mat;
    bool stat = true;
    int progress;

    void Start()
    {
        progress = 0;
        Opacity.value = progress;
        Mat.SetFloat("_OpacityParam", progress);
    }

    void FixedUpdate()
    {
        if (stat == true)
        {
            progress++;
            Opacity.value = progress;
            Mat.SetFloat("_OpacityParam", progress);
            if (progress == 100) stat = !stat;
        }
        if (stat == false)
        {
            progress--;
            Opacity.value = progress;
            Mat.SetFloat("_OpacityParam", progress);
            if (progress == 0) stat = !stat;
        }
    }
    private void OnApplicationQuit()
    {
        Mat.SetFloat("_OpacityParam", 0);
        Opacity.value = 0;
    }
}