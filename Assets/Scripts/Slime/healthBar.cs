using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Image hpbar;
    void Update()
    {
        hpbar.fillAmount = (GetComponent<Enemy>().healthOfEnemy / GetComponent<Enemy>().maxHP);
    }
}
