using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawn : MonoBehaviour
{
    public GameObject slime;
    public Transform spawnPosition;
    void Start()
    {
        StartCoroutine(Spawning(2f));
    }

    private IEnumerator Spawning(float spawnTime)
    {
        while (true)
        {
            GetComponent<killCounter>().numbOfKills++;
            yield return new WaitForSeconds(spawnTime);
            if (Random.value > 0.75f && Random.value < 1f)
            {
                Instantiate(slime, spawnPosition.position + new Vector3(Random.Range(14f, 16f), Random.Range(7f, 10f), 0f), transform.rotation);
            }
            if (Random.value > 0.50f && Random.value < 0.75f)
            {
                Instantiate(slime, spawnPosition.position + new Vector3(Random.Range(-14f, -16f), Random.Range(7f, 10f), 0f), transform.rotation);
            }
            if (Random.value > 0.25f && Random.value < 0.50f)
            {
                Instantiate(slime, spawnPosition.position + new Vector3(Random.Range(-14f, -16f), Random.Range(-7f, -10f), 0f), transform.rotation);
            }
            if (Random.value > 0f && Random.value < 0.25f)
            {
                Instantiate(slime, spawnPosition.position + new Vector3(Random.Range(14f, 16f), Random.Range(-7f, -10f), 0f), transform.rotation);
            }
        }
    }
}
