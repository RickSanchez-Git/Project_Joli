using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingVert : MonoBehaviour
{
    public float backgroundSizeVert = 14.7f;
    public float viewZoneVert = 8f;

    private Transform cameraTransformVert;
    public Transform[] layersTwo;

    private int upIndex;
    private int downIndex;

    private void Start()
    {
        cameraTransformVert = Camera.main.transform;
        layersTwo = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            layersTwo[i] = transform.GetChild(i);
        }

        upIndex = 0;
        downIndex = layersTwo.Length - 1;
    }
    private void ScrollDown()
    {
        //int lastLeft = leftIndex;
        layersTwo[upIndex].position = new Vector3(transform.position.x, layersTwo[upIndex].position.y - backgroundSizeVert * 3, transform.position.z);

        downIndex = upIndex;

        upIndex++;

        if (upIndex == layersTwo.Length)
        {
            upIndex = 0;
        }
    }

    private void ScrollUp()
    {
        //int lastLeft = leftIndex;
        layersTwo[downIndex].position = new Vector3(transform.position.x, layersTwo[downIndex].position.y + backgroundSizeVert * 3, transform.position.z);

        upIndex = downIndex;

        downIndex--;

        if (downIndex < 0)
        {
            downIndex = layersTwo.Length - 1;
        }
    }

    private void Update()
    {
        if (cameraTransformVert.position.y < (layersTwo[downIndex].transform.position.y + viewZoneVert))
        {
            ScrollDown();
        }

        if (cameraTransformVert.position.y > (layersTwo[upIndex].transform.position.y - viewZoneVert))
        {
            ScrollUp();
        }
    }

}
