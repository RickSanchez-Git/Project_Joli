using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;


public class UpgradeMenu : MonoBehaviour
{
    public bool timeToUpgrade;
    public GameObject upgradeMenu;

    private bool buttonIsPressed;
    void Start()
    {
        buttonIsPressed = false;
        upgradeMenu.SetActive(false);
        timeToUpgrade = false;
    }


    void Update()
    {
        if (timeToUpgrade)
        {
            timeToUpgrade = false;
            upgradeCall();
        }
    }

    void upgradeCall()
    {
        upgradeMenu.SetActive(true);
    }

    public async void speedUpgrade()
    {
        if (!buttonIsPressed)
        {
            buttonIsPressed = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().speed += 1f;
            await Task.Delay(500);
            resumeGame();
            resetBoolean();
        }
    }
    public async void ATKspeedUpgrade()
    {
        if (!buttonIsPressed)
        {
            buttonIsPressed = true;
            GameObject.FindGameObjectWithTag("Bow").GetComponent<arrowSpawn>().startingTimeBTS -= GameObject.FindGameObjectWithTag("Bow").GetComponent<arrowSpawn>().startingTimeBTS * 0.05f;
            await Task.Delay(500);
            resumeGame();
            resetBoolean();
        }
        
    }

    public async void ATKUpgrade()
    {
        if (!buttonIsPressed)
        {
            buttonIsPressed = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<difficulty>().damage++;
            await Task.Delay(500);
            resumeGame();
            resetBoolean();
        }
    }

    public void resumeGame()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<SlimeSpawn>().startCor = true;
        upgradeMenu.SetActive(false);
        buttonIsPressed = false;
    }

    private void resetBoolean()
    {
        GameObject.FindGameObjectWithTag("FrontProgressBar").GetComponent<ProgressBar>().fill = 1f;
        GameObject.FindGameObjectWithTag("FrontProgressBar").GetComponent<ProgressBar>().minFill = 1f;
        GameObject.FindGameObjectWithTag("FrontProgressBar").GetComponent<ProgressBar>().progBar.fillAmount = 1f;
        GameObject[] btns = GameObject.FindGameObjectsWithTag("Button");
        for (int i = 0; i < btns.Length; i++)
        {
            btns[i].GetComponent<ClickAnimation>().anim.SetBool("Click", false);
        }
    }
}
