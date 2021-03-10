using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeStart = 0.0f;
   [SerializeField] private Text texBox;
    

 

    // So you can check the actual time and the graph, good for debugging and for you to see that the graph is working
    void Update()
    {
        timeStart += Time.deltaTime;
        texBox.text= timeStart.ToString();
    }
}
