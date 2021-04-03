using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowSpawn : MonoBehaviour
{
    public float offset;
    public GameObject arrow;
    public Transform shotPoint;
    public float startingTimeBTS;

    private float timeBTS;
    private void Start()
    {
        startingTimeBTS = 0.9f;
    }
    void Update()
    {
        if (GameObject.Find("Canvas").GetComponent<Pause_Menu>().GameIsPaused == false && !GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<UpgradeMenu>().upgradeMenu.activeInHierarchy)
        {
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
            if (timeBTS <= 0)
            {
                if (Input.GetMouseButton(0))
                {
                    Instantiate(arrow, shotPoint.position, transform.rotation);
                    timeBTS = startingTimeBTS;
                }
            }
            else
            {
                timeBTS -= Time.deltaTime;
            }
        } 
    }
}
