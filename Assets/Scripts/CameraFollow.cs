using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] SineWave sine;
    public float chaseDist = 16.0f;
    private Vector3 temp;

   private void LateUpdate()
   {
       temp = transform.position;
       //chaseDistance / 2 is a good offset
       temp.x = (sine.GetPos().x - (chaseDist/2));
       //make the camera move only when the wave is about to leave the screen
       if (sine.GetPos().x > chaseDist)
       {
           transform.position = temp;
       }
   }
}
