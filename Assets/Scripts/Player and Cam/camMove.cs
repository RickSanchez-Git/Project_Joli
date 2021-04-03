using UnityEngine;

public class camMove : MonoBehaviour
{
    
    public float dumping = 5f;
    public GameObject player;


    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z), dumping * Time.deltaTime);
    }
}