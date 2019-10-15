using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    public GameObject Cubes;

    private GameObject[,] cubes;
    private Vector3[,] positionOffsets;

    AudioSource m_MyAudioSource;


    // Use this for initialization
    void Start()
    {

        m_MyAudioSource = GetComponent<AudioSource>();

        cubes = new GameObject[5, 5];
        positionOffsets = new Vector3[5, 5];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                cubes[i, j] = Instantiate(Cubes, new Vector3(2 * i - 5, 2 * j - 5, 0), Quaternion.identity);
                positionOffsets[i, j] = cubes[i, j].transform.position;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                cubes[i, j].transform.position = new Vector3(cubes[i, j].transform.position.x, Mathf.Sin(Time.time) + positionOffsets[i, j].y, 0);
            }
        }

        if (Input.GetKey("a"))
        {
            m_MyAudioSource.Play();

        }


    }

}
