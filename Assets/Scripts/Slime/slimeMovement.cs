using UnityEngine;

public class slimeMovement : MonoBehaviour
{
    public GameObject rb;
    private float slimeSpd;

    private Rigidbody2D slimeRb;

    void Start()
    {
        slimeRb = GetComponent<Rigidbody2D>();
        rb = GameObject.FindGameObjectWithTag("Player");
        slimeSpd = rb.GetComponent<difficulty>().slimeSpeed;
    }

    void Update()
    {
        slimeRb.MovePosition(slimeRb.position + new Vector2(((rb.transform.position.x * -1) + slimeRb.position.x) * -1, 
            ((rb.transform.position.y * -1) + slimeRb.position.y) * -1).normalized * slimeSpd * Time.deltaTime);
    }
}
