using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelloader : MonoBehaviour
{
    public Animator transition;

    public void LoadStartLevel()
    {
        StartCoroutine(LoadStart(1));
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        StartCoroutine(LoadStart(0));
    }

    IEnumerator LoadStart(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelIndex);
    }
}
