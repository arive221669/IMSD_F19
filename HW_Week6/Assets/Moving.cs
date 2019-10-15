using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

    public GameObject Cubes;
    public GameObject SecondSound;

    private GameObject[,] cubes;
    private Vector3[,] positionOffsets;

    AudioSource myAudioSource;


    // Use this for initialization
    void Start()
    {

        myAudioSource = GetComponent<AudioSource>();

        cubes = new GameObject[3, 3];
        positionOffsets = new Vector3[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                cubes[i, j] = Instantiate(Cubes, new Vector3(2 * i - 2, 2 * j - 2, 0), Quaternion.identity);
                positionOffsets[i, j] = cubes[i, j].transform.position;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                cubes[i, j].transform.position = new Vector3(cubes[i, j].transform.position.x, Mathf.Sin(Time.time) + positionOffsets[i, j].y, 0);
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            myAudioSource = gameObject.GetComponent<AudioSource>();
            myAudioSource.Play();

        }

        if (Input.GetKey(KeyCode.Space))
        {

            myAudioSource = SecondSound.gameObject.GetComponent<AudioSource>();
            myAudioSource.Play();

        }


    }

}
