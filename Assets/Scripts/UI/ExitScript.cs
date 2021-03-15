using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
