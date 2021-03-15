using UnityEngine;

public class healthMove : MonoBehaviour
{
    public GameObject player;
    public GameObject bar;
    // Start is called before the first frame update
    void Start()
    {
        bar = GameObject.FindGameObjectWithTag("healthContainer");
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        bar.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
    }
}
