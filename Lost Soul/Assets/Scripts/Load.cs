using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public void LoadScene(string _SceneName)
    { SceneManager.LoadScene(_SceneName); }
}

