using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    public Camera m_camera;
    public GameObject brush;
    LineRenderer currentLineRenderer;
    public Vector2 startPos;
    Vector2 lastpos = Vector2.zero;
    [SerializeField] SineWave sine;
    float my_time ;

    private void Start()
    {
        //This makes sure that we are updating always at the same speed
        Application.targetFrameRate = 30;
        // This makes the Brush
        CreateBrush();
    }

    private void FixedUpdate()
    {
        Draw();
    }
    private void Draw()
    {
        
        Vector2 myPos = sine.WaveForm();
        AddPoint(myPos);
         if (myPos != lastpos)
         {
             AddPoint(myPos);
             lastpos = myPos;
         }
    }

    void CreateBrush()
    {
        GameObject brushInstance = Instantiate(brush);
        currentLineRenderer = brushInstance.GetComponent<LineRenderer>();
        
        //The only way to instantiate the brush in such a way that it won't draw and teleport to the Sine Wave
        Vector2 myPos = sine.WaveForm();
        currentLineRenderer.SetPosition(0,myPos);
        currentLineRenderer.SetPosition(1,myPos);

    }

    void AddPoint(Vector2 pointPos)
    {
        // This adds points and stores them
        currentLineRenderer.positionCount++;
        int positionIndex = currentLineRenderer.positionCount - 1;
        currentLineRenderer.SetPosition(positionIndex,pointPos);
    }
}
