using UnityEngine;

public class slimeMovement : MonoBehaviour
{
    public GameObject rb;
    public float slimeSpeed = 1f;

    private Rigidbody2D slimeRb;

    public float moveX = 0f;
    public float moveY = 0f;
    void Start()
    {
        slimeRb = GetComponent<Rigidbody2D>();
        rb = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        /*
        if (slimeRb.position.x < (rb.transform.position.x - 0.1f))
        {
           moveX = 1f;
        } 
        if (slimeRb.position.x > (rb.transform.position.x + 0.1f))
        {
           moveX = -1f;
        }
        if (slimeRb.position.y < (rb.transform.position.y - 0.1f))
        {
            moveY = 1f;
        }
        if (slimeRb.position.y > (rb.transform.position.y + 0.1f))
        {
            moveY = -1f;
        }
        
        slimeRb.MovePosition(slimeRb.position + Vector2.right * moveX * slimeSpeed * Time.deltaTime 
            + Vector2.up * moveY * slimeSpeed * Time.deltaTime);
        */
        slimeRb.MovePosition(slimeRb.position + new Vector2(((rb.transform.position.x * -1) + slimeRb.position.x) * -1, ((rb.transform.position.y * -1) + slimeRb.position.y) * -1) * slimeSpeed * Time.deltaTime);
        moveX = 0f;
        moveY = 0f;
    }
}
