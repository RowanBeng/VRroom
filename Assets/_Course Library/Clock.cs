using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour 
{

    Quaternion hourRotation;
    Quaternion minuteRotation;
    Quaternion secondRotation;

    public GameObject hourHand;
    public GameObject minuteHand;
    public GameObject secondHand; 

    DateTime currentTime;

    private void Update()
    {

        currentTime = DateTime.Now;

        hourRotation = Quaternion.Euler( 90 + ( currentTime.Hour / 12f ) * 360f, -90f, -90f );
        hourHand.transform.rotation = hourRotation;

        minuteRotation = Quaternion.Euler( 90 + ( currentTime.Minute / 60f ) * 360f, -90f, -90f );
        minuteHand.transform.rotation = minuteRotation;

        secondRotation = Quaternion.Euler( 90 + ( currentTime.Second / 60f ) * 360f, -90f, -90f );
        secondHand.transform.rotation = secondRotation;
    }

}