using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SineWave : MonoBehaviour
{
    Vector2 myPos;

    public Slider slideFreq;
    public Slider slideAmpl;
    private float amplitude = 1;
    private float frequency = 1;
    private float myX;
    private float anotherY;
    private float myTime;

    
    public Vector2 WaveForm()
    {
        myTime += Time.deltaTime;
        //Simply using the SineWave formula and storing it
        anotherY = amplitude * Mathf.Sin(2 * Mathf.PI * myTime * frequency);
        //In thtis way the x is queal the time (as requested) and the Y is the actual SineWave
        myPos = new Vector2(myTime, anotherY);
        return myPos;
    }
    public Vector2 GetPos()
    {
        return myPos;
    }
    public void SetFreq()
    {
        frequency = slideFreq.value;
    }

    public void SetAmpl()
    {
       
        amplitude = slideAmpl.value;
    }

}
