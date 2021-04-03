using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Update()
    {
        if (GetComponent<PlayerMovement>().health <= 0.5f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
