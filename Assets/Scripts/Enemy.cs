using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


public class Enemy : MonoBehaviour
{
    Animator animEnemy;
    public float healthOfEnemy;
    public float maxHP;
    public float tmpp;

    private void Start()
    {
        healthOfEnemy = GameObject.Find("Player").GetComponent<difficulty>().MaxHp;
        maxHP = GameObject.Find("Player").GetComponent<difficulty>().MaxHp;
        animEnemy = GetComponent<Animator>();
    }
    public async void death()
    {
        if (healthOfEnemy <= GameObject.FindGameObjectWithTag("Player").GetComponent<difficulty>().damage && gameObject != null)
        {
            tmpp = GameObject.FindGameObjectWithTag("Player").GetComponent<difficulty>().currentHei;
            GameObject.FindGameObjectWithTag("Player").GetComponent<difficulty>().enemyCounter--;

            GameObject.FindGameObjectWithTag("FrontProgressBar").GetComponent<ProgressBar>().minFill -= GameObject.FindGameObjectWithTag("FrontProgressBar").GetComponent<ProgressBar>().kf;

            animEnemy.SetTrigger("Death");
            await Task.Delay(1000);
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            healthOfEnemy -= GameObject.FindGameObjectWithTag("Player").GetComponent<difficulty>().damage;
        }
    }
}
