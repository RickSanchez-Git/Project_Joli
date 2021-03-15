using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float healthOfEnemy;
    public float maxHP;
    private void Start()
    {
        healthOfEnemy = GameObject.Find("Player").GetComponent<difficulty>().MaxHp;
        maxHP = GameObject.Find("Player").GetComponent<difficulty>().MaxHp;
    }
    public void death()
    {
        if (healthOfEnemy == 1f)
        {
            Destroy(gameObject);
        }
        else
        {
            healthOfEnemy -= 1f;
        }
    }
}
