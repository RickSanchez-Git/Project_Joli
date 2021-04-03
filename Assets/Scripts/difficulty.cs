using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficulty : MonoBehaviour
{
    public float damage;
    public float MaxHp;
    public float currentHei;
    public float expD;
    public float enemyCounter;
    public float maxHpUP;
    public float slimeSpeed;
    void Start()
    {
        enemyCounter = 2f;
        currentHei = 2f;
        MaxHp = 1f;
        damage = 1f;
        expD = 1f;
        maxHpUP = 1f;
        slimeSpeed = 1f;
    }

    void Update()
    {
        if (enemyCounter == 0)
        {
            currentHei = Mathf.Round(Mathf.Exp(expD));
            enemyCounter = currentHei;
            GameObject.FindGameObjectWithTag("FrontProgressBar").GetComponent<ProgressBar>().kf = 1 / currentHei;
            slimeSpeed += 0.3f;
            maxHpUP++;
            if (maxHpUP > 2f)
            {
                MaxHp++;
                maxHpUP = 0f;
            }
            expD += 0.3f;
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<SlimeSpawn>().spawn_Time > 0.4f)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<SlimeSpawn>().spawn_Time -= 0.1f;
            }
            GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<UpgradeMenu>().timeToUpgrade = true;
        }
    }
}
