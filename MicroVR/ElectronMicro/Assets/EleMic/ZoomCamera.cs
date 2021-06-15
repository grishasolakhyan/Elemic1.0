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

    private float ProX;
    private float ProY;
    private float ProZ;

    public float speed = .2f;
    private Vector3 ang;

    private void Start()
    {
        Application.targetFrameRate = 60;
        startingPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    private void Update()
    {
        GetComponent<Transform>().rotation = Quaternion.Euler(ang);
        currentX = transform.position.x;
        currentY = transform.position.y;
        currentZ = transform.position.z;
        //вперёд и назад
        ProX = speed;
        ProY = speed;
        ProZ = speed;

        if (Input.GetKey(KeyCode.E))
        {
            currentZ += ProZ;
            GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            currentZ -= ProZ;
            GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        }

        //влево и вправо
        if (Input.GetKey(KeyCode.A))
        {
            currentX -= ProX;
            GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        }
        if (Input.GetKey(KeyCode.D))
        {
            currentX += ProX;
            GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        }

        //вверх и вниз
        if (Input.GetKey(KeyCode.W))
        {
            currentY += ProY;
            GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        }
        if (Input.GetKey(KeyCode.S))
        {
            currentY -= ProY;
            GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        }

        currentX = Mathf.Clamp(currentX, minPos, maxPos);
        currentY = Mathf.Clamp(currentY, minPos, maxPos);
        currentZ = Mathf.Clamp(currentZ, minPos, -1);
        GetComponent<Transform>().position = new Vector3(currentX, currentY, currentZ);
        ang = transform.rotation.eulerAngles;

        //возврат на начальную позицию
        if (Input.GetKey(KeyCode.I))
        {
            float go = 1f;
            GetComponent<Transform>().position = Vector3.Lerp(transform.position, startingPos, go);
        }
    }
}
