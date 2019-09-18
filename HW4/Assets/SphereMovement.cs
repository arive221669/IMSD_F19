using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public GameObject WarpSpace;

     void Start()
    {
        RowOfSpheres();
    }
    void Update()
    {
        Debug.Log(Time.time);
        if (Time.time < 10)
        {
            Vector3 TheUpDownPosition = transform.position;
            TheUpDownPosition.y = Mathf.Sin(Time.time) * 3; 
            this.transform.position = TheUpDownPosition;
        }

        else if (Time.time > 10 && Time.time < 15)
        {
            Vector3 TheLeftRightPosition = transform.position;
            TheLeftRightPosition.x = Mathf.Cos(Time.time) * 8;
            this.transform.position = TheLeftRightPosition;
        }

        else
        {
            Vector3 TheInOutPosition = transform.position;
            TheInOutPosition.z = Mathf.Tan(Time.time) * 5;
            this.transform.position = TheInOutPosition;
        }
    }

    void RowOfSpheres()
    {
        for (int xPos = 0; xPos < 10; xPos++)
        {
            for (int yPos = 0; yPos < 1; yPos++)
            {
                Instantiate(WarpSpace, new Vector3(xPos * 2 - 10, yPos * 1.5f, 3), Quaternion.identity);
            }
        }
    }

}