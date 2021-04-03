using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDoDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")

            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().health -= 1f;
    }
}
