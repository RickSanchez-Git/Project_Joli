using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrees : MonoBehaviour
{
    private Transform playerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        if (Mathf.Abs(playerPos.position.x - transform.position.x) > 37f || Mathf.Abs(playerPos.position.y - transform.position.y) > 18f)
        {
            Destroy(gameObject);
        }
    }
}
