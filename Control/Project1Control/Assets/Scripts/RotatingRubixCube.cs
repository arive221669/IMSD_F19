using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingRubixCube : MonoBehaviour {

    private float spinX = 0.5f;

	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(-30, 2, 0);
        transform.Rotate(spinX, 0, 0);

    }
}
