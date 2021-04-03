using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerlinNoise : MonoBehaviour
{
    public GameObject[] obj;
    //public float delta = 2f;

    private Vector3 currentPos;
    private float[] sign = new float[2] {1f, -1f};
    private Vector3 coords;
    private float perlNoiseValue;

    private void Start()
    {
        currentPos = transform.position;
    }
    private void Update()
    {
        if(currentPos != transform.position)
        {
            for (int i = 0; i < 3; i++)
            {
                createTrees();
            }
            currentPos = transform.position;
        }
    }

    public void createTrees()
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                generatePoint(sign[i], sign[j]);
            }
        }
    } 

    void generatePoint(float signX, float signY)
    {
        coords = new Vector3(Random.Range(transform.position.x, transform.position.x + 15f * signX),
            Random.Range(transform.position.y, transform.position.y + 7.5f * signY), 10.48f);
        perlNoiseValue = Mathf.PerlinNoise(coords.x, coords.y);
        if (perlNoiseValue < 0.33f)
        {
            Instantiate(obj[0], coords, transform.rotation);
        }
        else if (perlNoiseValue < 0.66f)
        {
            Instantiate(obj[1], coords, transform.rotation);
        }
        else if (perlNoiseValue < 1f)
        {
            Instantiate(obj[2], coords, transform.rotation);
        }
    }
}
