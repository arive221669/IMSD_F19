using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowandShrink : MonoBehaviour
{

    float changeSize = 1;
    bool isTrue;

    float limit = 10;


    void Start()
    {

    }

    void Update()
    {
        ChangeSphereSize();
    }

    void ChangeSphereSize()
    {

        if (Input.GetKey(KeyCode.Q) && isTrue == true)
        {
            gameObject.transform.localScale += new Vector3(changeSize, changeSize, changeSize) * Time.deltaTime;
            limit += 0.5f;
            if(limit >= 10)
            {
                isTrue = false;
            }
        }
        else if (Input.GetKey(KeyCode.W) && isTrue == false)
        {
            gameObject.transform.localScale -= new Vector3(changeSize, changeSize, changeSize) * Time.deltaTime;
            limit -= 0.5f;

            if(limit <= 0)
            {
                isTrue = true;
            }
        }
    }

}
