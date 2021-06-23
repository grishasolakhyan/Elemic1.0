using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testCamera : MonoBehaviour
{
    public Camera Cam;
    private Vector3 startPos;
    public Vector3 firstPos;
    public Vector3 secondPos;
    public float step;
    private float progress;
    bool t=true;

    void Start()
    {
        startPos=Cam.transform.position;
    }

    public void FixedUpdate()
    {
            if (t == true)
            {
                Cam.transform.position = Vector3.Lerp(firstPos, secondPos, progress);
                progress += step;
                if (progress > 1) t = !t;
            }
            if (t == false)
            {
                Cam.transform.position = Vector3.Lerp(firstPos, secondPos, progress);
                progress -= step;
                if (progress <= 0) t = !t;
            }
    }

    private void OnApplicationQuit()
    {
        Cam.transform.position = startPos;
    }
}
