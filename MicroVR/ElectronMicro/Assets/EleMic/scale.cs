using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class scale : MonoBehaviour
{
    public Camera Cam;
    public Text Scale_text;
    private float firstposz;
    private float lastposz;
    float dist;
    float scal;

    private void Start()
    {
        firstposz = Cam.GetComponent<Transform>().position.z;
        lastposz = firstposz;
    }

    private void Update()
    {
        lastposz = Cam.GetComponent<Transform>().position.z;
        if (lastposz != firstposz)
        {
            dist = Math.Abs(lastposz);
            scal = 100 * (dist / 10);
            Scale_text.text = Math.Round(scal, 2) + " µm";
            firstposz = lastposz;
        }
    }
}
