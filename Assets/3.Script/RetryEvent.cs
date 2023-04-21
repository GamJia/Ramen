using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryEvent : MonoBehaviour
{
    
    public void SceneLoader()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("1.Scene/01.Intro");
    }
}
