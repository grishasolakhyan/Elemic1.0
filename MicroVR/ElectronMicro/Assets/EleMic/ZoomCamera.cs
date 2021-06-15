using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    public Vector3 startingPos;
    public Vector3 startingRot;

    private float currentX;
    private float currentY;
    private float currentZ;

    public float minPos;
    public float maxPos;

    public float Hspeed=2.0f;
    public float Vspeed=2.0f;

    private float yaw=0.0f;
    private float pitch=0.0f;

    private double ProX;
    private double ProY;
    private double ProZ;

    private float ProX1;
    private float ProY1;
    private float ProZ1;

    public double speed = .2f;

    private Quaternion t;
    private Vector3 ang;

    private void Start()
    {
        Application.targetFrameRate = 60;
        startingPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        startingRot = transform.rotation.eulerAngles; 
    }

    private void Update()
    {
        GetComponent<Transform>().rotation = Quaternion.Euler(ang);
        currentX = transform.position.x;
        currentY = transform.position.y;
        currentZ = transform.position.z;
        //вперёд и назад
        ProX = speed * Math.Cos(transform.rotation.eulerAngles.x * Math.PI / 180)* Math.Cos(transform.rotation.eulerAngles.y * Math.PI / 180);
        ProX1 = (float)ProX;
        ProY = speed * Math.Sin(transform.rotation.eulerAngles.x * Math.PI / 180);
        ProY1 = (float)ProY;
        ProZ = speed * Math.Cos(transform.rotation.eulerAngles.x * Math.PI / 180) * Math.Sin(transform.rotation.eulerAngles.y * Math.PI / 180);
        ProZ1 = (float)ProZ;

        if (Input.GetKey(KeyCode.W))
        {
            currentX += ProZ1;
            currentY -= ProY1;
            currentZ += ProX1;
            GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        }
        if (Input.GetKey(KeyCode.S))
        {
            currentX -= ProZ1;
            currentY += ProY1;
            currentZ -= ProX1;
            GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        }

        //влево и вправо
        if (Input.GetKey(KeyCode.A))
        {
            currentX -= ProX1;
            currentZ += ProZ1;
            GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        }
        if (Input.GetKey(KeyCode.D))
        {
            currentX += ProX1;
            currentZ -= ProZ1;
            GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        }

        if (Input.GetMouseButton(2))
        {
            yaw += Hspeed * Input.GetAxis("Mouse X");
            pitch -= Vspeed * Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

        currentX = Mathf.Clamp(currentX, minPos, maxPos);
        currentY = Mathf.Clamp(currentY, minPos, maxPos);
        currentZ = Mathf.Clamp(currentZ, minPos, maxPos);
        GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        ang = transform.rotation.eulerAngles;

        //возврат на начальную позицию
        if (Input.GetKey(KeyCode.I))
        {
            //GetComponent<Transform>().position = startingPos;
            //GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, 0);
            float go = 0.15f;
            GetComponent<Transform>().position = Vector3.Lerp(transform.position, startingPos, go);
            t = Quaternion.Euler(0, 0, 0);
            GetComponent<Transform>().rotation = Quaternion.Lerp(transform.rotation, t, go);
            ang = transform.rotation.eulerAngles;
        }
    }
}
