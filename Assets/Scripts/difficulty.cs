using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficulty : MonoBehaviour
{
    public float MaxHp;
    public float currentHei = 3f;
    void Start()
    {
        MaxHp = 1f;
    }

    void Update()
    {
        if (GetComponent<killCounter>().numbOfKills > currentHei - 1f)
        {
            currentHei += 3;
            MaxHp++;
        }
    }
}
