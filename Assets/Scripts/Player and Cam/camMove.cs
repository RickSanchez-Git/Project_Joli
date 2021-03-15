using UnityEngine;

public class camMove : MonoBehaviour
{
    
    public float dumping = 5f;
    /*
    public Vector2 offset = new Vector2(2f, 1f);
    public bool isLeft;
    private int lastX;
    */
    public GameObject player;


    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z), dumping * Time.deltaTime);
    }
}


//(player.transform.position.x, player.transform.position.y, -10f);