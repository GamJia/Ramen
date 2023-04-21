using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    [SerializeField] GameObject settings;
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

    public void OpenTistory()
    {
        Application.OpenURL("https://gamjia.tistory.com/");
    }   

    public void OpenInstagram()
    {
        Application.OpenURL(" https://instagram.com/rwxr__r__?igshid=ZDdkNTZiNTM=");
    }

    public void SettingEnter()
    {
        settings.SetActive(true);
    }

    public void SettingQuits()
    {
        settings.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
