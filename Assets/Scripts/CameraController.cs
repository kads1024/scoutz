﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float Yaxis;
    public float Xaxis;

    public float rotationMin;
    public float rotationMax;

    public float Sensitivity;
    public List<Transform> target;

    private Vector3 targetRotation;
    private Vector3 rotationVelocity;
    public float rotationSmoothness;

    public FixedTouchField touchField;

    int character;
    private void Start()
    {
        if (PlayerPrefs.GetString("Gender") == "Boy") character = 0;
        else if (PlayerPrefs.GetString("Gender") == "Girl") character = 1;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        Yaxis += touchField.TouchDist.x * Sensitivity;
        Xaxis -= touchField.TouchDist.y * Sensitivity;
        Xaxis = Mathf.Clamp(Xaxis, rotationMin, rotationMax);

        targetRotation = Vector3.SmoothDamp(targetRotation, new Vector3(Xaxis, Yaxis), ref rotationVelocity, rotationSmoothness);
        transform.eulerAngles = targetRotation;
        transform.position = target[character].position - transform.forward * 2.5f;
    }
}
