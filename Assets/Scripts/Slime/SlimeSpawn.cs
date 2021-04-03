using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawn : MonoBehaviour
{
    public bool startCor;
    public GameObject slime;
    public Transform spawnPosition;
    public float spawn_Time;
    private void Start()
    {
        spawn_Time = 4f;
        startCor = true;
    }
    private void Update()
    {
        if (startCor)
        {
            startCor = false;
            StartCoroutine(Spawning(spawn_Time));
        }
    }
    private IEnumerator Spawning(float spawnTime)
    {
        for (int i = 0; i < GameObject.FindGameObjectWithTag("Player").GetComponent<difficulty>().currentHei; i++)
        {
            yield return new WaitForSecondsRealtime(spawnTime);
            float temp = Random.value;
            if (temp > 0.75f && temp < 1f)
            {
                Instantiate(slime, spawnPosition.position + new Vector3(Random.Range(6f, 8f), Random.Range(7f, 10f), 0.5f), transform.rotation);
            } else if (temp > 0.50f && temp < 0.75f)
            {
                Instantiate(slime, spawnPosition.position + new Vector3(Random.Range(-6f, -8f), Random.Range(7f, 10f), 0.5f), transform.rotation);
            } else if (temp > 0.25f && temp < 0.50f)
            {
                Instantiate(slime, spawnPosition.position + new Vector3(Random.Range(-6f, -8f), Random.Range(-7f, -10f), 0.5f), transform.rotation);
            } else if (temp > 0f && temp < 0.25f)
            {
                Instantiate(slime, spawnPosition.position + new Vector3(Random.Range(6f, 8f), Random.Range(-7f, -10f), 0.5f), transform.rotation);
            }
        }
    }
}
