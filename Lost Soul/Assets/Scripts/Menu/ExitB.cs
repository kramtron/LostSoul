using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitB : MonoBehaviour
{
    public void     ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
