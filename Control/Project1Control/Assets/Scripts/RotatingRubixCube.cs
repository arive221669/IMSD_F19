using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingRubixCube : MonoBehaviour {

    private float spinX = 0.5f;
    private float spinY = 0.5f;
    private float spinZ = 0.5f;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0, spinY, 0);

    }
}
