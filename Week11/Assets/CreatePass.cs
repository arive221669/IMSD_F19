using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePass : MonoBehaviour
{

    Transform[] boxes = new Transform[3];
    public GameObject prefabOfSphere;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject g = Instantiate(prefabOfSphere, new Vector3(-3 + 2 * i, 0, 0), Quaternion.identity);
            boxes[i] = g.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveSphereUpOrDown(boxes[0], Input.GetKey(KeyCode.E));
        MoveSphereUpOrDown(boxes[1], Input.GetKey(KeyCode.E));
        MoveSphereUpOrDown(boxes[2], Input.GetKey(KeyCode.E));

    }

    void MoveSphereUpOrDown(Transform box, bool upDown)
    {
        Vector3 hold = box.position;
        if (upDown)
            hold.y = 1;
        else
            hold.y = 0;
        box.position = hold;
    }
}
