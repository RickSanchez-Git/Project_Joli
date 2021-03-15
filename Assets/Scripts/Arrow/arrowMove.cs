using System.Collections;
using UnityEngine;

public class arrowMove : MonoBehaviour
{
    public float speed;
    public float distance;
    public LayerMask whatIsSolid;
    public GameObject player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine("notExisting");
    }
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<Enemy>().death();
            }
            Destroy(gameObject);
        }
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    public IEnumerator notExisting()
    {
       yield return new WaitForSeconds(1.3f);
       Destroy(gameObject);
    }
}
