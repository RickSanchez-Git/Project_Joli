using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class ProgressBar : MonoBehaviour
{
    public Image progBar;

    public float minFill;
    public float kf;
    public float fill;

    private void Start()
    {
        kf = 0.5f;
        minFill = 1f;
        fill = 1f;
        progBar = GetComponent<Image>();
    }
    void Update()
    {
        if (minFill < fill)
        {
            fill -= 0.8f * Time.deltaTime;
            progBar.fillAmount = fill;
        }
    }

}