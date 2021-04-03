using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float backgroundSize = 29.78f;
    public float viewZone = 12f;

    private Transform cameraTransform;
    public Transform[] layers;

    private int leftIndex;
    private int rightIndex;

    
    void Start()
    {
        cameraTransform = Camera.main.transform;
        layers = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            layers[i] = transform.GetChild(i);
        }

        leftIndex = 0;
        rightIndex = layers.Length - 1;
    }
    
    //Scrolling in hotizontal orientation 
    private void ScrollLeft()
    {
        //int lastRight = rightIndex;
        layers[rightIndex].position = new Vector3(layers[rightIndex].position.x - (backgroundSize * 3), 0, transform.position.z);
        leftIndex = rightIndex;
        rightIndex--;

        if (rightIndex < 0)
        {
            rightIndex = layers.Length - 1;
        }
    }
    

    private void ScrollRight()
    {
        //int lastLeft = leftIndex;
        layers[leftIndex].position = new Vector3(layers[leftIndex].position.x + (backgroundSize * 3), 0, transform.position.z);
        
        rightIndex = leftIndex;

        leftIndex++;

        if (leftIndex == layers.Length)
        {
            leftIndex = 0;
        }
    }

    private void Update()
    {
        if (cameraTransform.position.x < (layers[leftIndex].transform.position.x + viewZone))
        {
            ScrollLeft();
        }
        
        if(cameraTransform.position.x > (layers[rightIndex].transform.position.x - viewZone))
        {
            ScrollRight();
        }
    }
}
