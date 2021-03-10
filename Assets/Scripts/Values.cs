using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Values : MonoBehaviour
{
    private float my_val;
    public Slider slider;
    public Text textBox;
    public string myString;

    //This is to display the text at the beginning of the application,otherwise it would be displayed only after the slider is moved for the first time
    private void Start()
    {
        my_val = slider.value;
        textBox.text = myString + my_val.ToString("F2");
    }

    //This one gets called when the slider moves
    public void SetVal()
    {
        my_val = slider.value;
        textBox.text = myString + my_val.ToString("F2");
        
    }
}
