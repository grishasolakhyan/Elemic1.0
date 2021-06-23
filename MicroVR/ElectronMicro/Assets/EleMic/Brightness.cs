using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brightness : MonoBehaviour
{
    public Slider brightness_Slid;
    public Slider contrast_Slid;
    public Slider opacity_Slid;

    public Text br_per;
    public Text co_per;
    public Text op_per;

    public Material Mat;

    public float br_val;
    public float co_val;
    public float op_val;

    private void Start()
    {
        Mat.SetFloat("_BrightnessParam", 0);
        Mat.SetFloat("_OpacityParam", 100);
    }

    public void Bright_slid()
    {
        br_val = brightness_Slid.value;
        Mat.SetFloat("_BrightnessParam", br_val);
    }
    public void Contrast_slid()
    {
        co_val = contrast_Slid.value;

    }
    public void Opacity_slid()
    {
        op_val = opacity_Slid.value;
        Mat.SetFloat("_OpacityParam", op_val);

    }

    public void br_Percents()
    {
        br_per.text = br_val + "%";
    }
    public void co_Percents()
    {
        co_per.text = co_val + "%";
    }
    public void op_Percents()
    {
        op_per.text = op_val + "%";
    }
    private void OnApplicationQuit()
    {
        Mat.SetFloat("_BrightnessParam", 0);
        Mat.SetFloat("_OpacityParam", 100);
    }
}
