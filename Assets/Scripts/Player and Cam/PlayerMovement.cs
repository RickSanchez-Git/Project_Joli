using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    public float moveX;
    public float moveY;
    public float health;
    public float speed;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public float heal;
    Animator anim;

    private Rigidbody2D rb;

    private bool faceRight = true;

    // Start is called before the first frame update
    void Start()
    {
        heal = 0.1f;
        speed = 3f;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        health += Time.deltaTime * heal;
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Mathf.RoundToInt(health))
            {
                hearts[i].sprite = fullHeart;
            } else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false;
            }
        }
        moveY = Input.GetAxis("Vertical");
        moveX = Input.GetAxis("Horizontal");
        if ((moveX != 0 || moveY != 0) && !GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<UpgradeMenu>().upgradeMenu.activeInHierarchy)
        {
            anim.SetBool("Jump", true);
        } else {
            anim.SetBool("Jump", false);
        }
        if (!GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<UpgradeMenu>().upgradeMenu.activeInHierarchy)
        {
            rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime
                + Vector2.up * moveY * speed * Time.deltaTime);
            if (moveX > 0 && !faceRight)
                flip();
            else if (moveX < 0 && faceRight)
                flip();
        }
    }

    void flip()
    {
        faceRight = !faceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
        if (moveX < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
