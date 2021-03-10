using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChucnkSpawner : MonoBehaviour
{
    [SerializeField] private GameObject AxisPrefab;
    [SerializeField] private Transform myCamera;

    //Just something where to store and modify the current position
    private Vector3 temp;
    //because the pivot point is in the middle of the Axis xSpawn has to be 8 in order to compensate the fact that the pivot point is in the middle
    private float xSpawn = 8;
    // This is like the i in a forloop where you need a variable to iterate, and is also the multiplier for the text
    private int timesSpawned = 0;
    //This is the offset for spawn the other Axis one after the other
    private int chucnkLength = 16;
    // This is the offset that I use for have the correct numbers on the axis
    private int numOffset;


    // Update is called once per frame
    void Update()
    {
        //When the camera is about to leave spawn another axis
        if (myCamera.position.x > (xSpawn - chucnkLength))
        {
            SpawnChucnk();
        }

    }

    public void SpawnChucnk()
    {


        temp = transform.position;
        temp.y = -4.5f;
        temp.x = xSpawn;
        //Making sure that the fisrt number of the new axis is correct
        numOffset = timesSpawned * chucnkLength;

        GameObject myPrefab = Instantiate(AxisPrefab, temp, transform.rotation);


        
        for (int i = 0; i < chucnkLength; i++)
        {
            int my_numbers;
            //Having the numbers in ascending order, i+1 because it would start by 0 which I don't want it to.
            my_numbers = (i) + 1 + (numOffset);
         
        
            TextMeshPro prefabText = myPrefab.transform.GetChild(i).GetComponentInChildren<TextMeshPro>();
            prefabText.SetText(my_numbers.ToString());

        }


          
        //Adding the chuckLength as in a for loop so that the next spawn axis is adjacent to the previous one
        xSpawn += chucnkLength;
        //This is part of what makes the number on the axis correct
        timesSpawned++;
    }
}
