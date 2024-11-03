using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public void LoadScene()
    {
        string sceneName = "Level1";
        SceneManager.LoadScene(sceneName);
    }
}
