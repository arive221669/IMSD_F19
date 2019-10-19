using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithScene : MonoBehaviour
{
    public GameObject UserInputCube;
    private float timer;

    private float SpinX = 5f;
    private float SpinY = 5f;
    private float SpinZ = 5f;

    public Light ChangingColor;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.B))
        {
            UserInputCube.transform.localScale = new Vector3(2, 2, 2);
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            UserInputCube.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        if (Input.GetKey(KeyCode.Space))
        {
                transform.Rotate(SpinX, SpinY, SpinZ);
            
        }

        if (timer <= 10)
        {
            ChangingColor.color = new Color(Mathf.Sin(timer), 0, 0);
        }

        else if (timer >= 10 && timer <= 20)
        {
            ChangingColor.color = new Color(0, Mathf.Sin(timer), 0);
        }

        else if (timer >= 20)
        {
            ChangingColor.color = new Color(0, 0, Mathf.Sin(timer));
        }
    }
}
