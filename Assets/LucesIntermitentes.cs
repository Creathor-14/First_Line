﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using Random=UnityEngine.Random;

public class LucesIntermitentes : MonoBehaviour
{
    [SerializeField] private float betweenLightFlickers;
    [SerializeField] private float lightFlickerMin;
    [SerializeField] private float lightFlickerMax;
    [SerializeField] private float beginningTime;
    Light2D myLight;

    private void Start()
    {
        myLight = GetComponent<Light2D>();
        StartCoroutine(StartScene());
    }

    IEnumerator StartScene()
    {
        yield return new WaitForSeconds(beginningTime);
        StartCoroutine(LightFlicker());
    }

    IEnumerator LightFlicker()
    {
        yield return new WaitForSeconds(betweenLightFlickers);
        myLight.pointLightOuterRadius = Random.Range(lightFlickerMin,lightFlickerMax);
        StartCoroutine(LightFlicker());
    }
}