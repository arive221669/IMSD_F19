using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCubeMovement : MonoBehaviour {

    static int HowManyCubesAreLeft = 27;

    public GameObject RubixCube;


    Vector3 positionOffset;


    // Start is called before the first frame update
    void Start()
    {
        
        positionOffset = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (HowManyCubesAreLeft >= 1)
        {
            transform.position = new Vector3(Mathf.Tan(Time.time) * 3, Mathf.Sin(Time.time) * 7, Mathf.Cos(Time.time) * 3) + positionOffset;
        }

        if (HowManyCubesAreLeft == 0)
        {

            SpawnRubixCube();
            HowManyCubesAreLeft = -1;

        }
    }

    void OnMouseDown()
    {

        Destroy(this.gameObject);
        Debug.Log("Clicked");
        HowManyCubesAreLeft = HowManyCubesAreLeft - 1;
        Debug.Log("There are " + HowManyCubesAreLeft + " cubes left");

        if (HowManyCubesAreLeft == 0)
        {

            SpawnRubixCube();
            HowManyCubesAreLeft = 1;

        }

    }

    void SpawnRubixCube()
    {

        Instantiate(RubixCube, new Vector3(0, 2, 0), Quaternion.identity);

    }


}
