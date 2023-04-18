using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public void WaitforSec()
    {
        Invoke(nameof(LoadingScene), 0.3f);
    }

    public void LoadingScene()
    {
        SceneManager.LoadScene("1.Scene/02.Game");
    }
    public void SceneLoader(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }
}
