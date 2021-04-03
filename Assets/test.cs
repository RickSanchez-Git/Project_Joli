using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public Animator anima;
    public void click()
    {
        anima.SetTrigger("Click");
    }
}
