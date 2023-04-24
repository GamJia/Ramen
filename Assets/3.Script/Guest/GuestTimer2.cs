using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.UI;

public class GuestTimer2 : MonoBehaviour
{
    [SerializeField] public GameObject bar2;
    [SerializeField] SecondGuest secondguest;
    private void Update()    {

        if (bar2.transform.localScale.y == 0)
        {
            secondguest.CheckAnswer();
        }

        if (bar2.transform.localScale.y <= 0.3f)
        {
            bar2.GetComponent<Image>().color = new Color32(255, 96, 96, 255);
        }

        if (bar2.transform.localScale.y > 0.3f)
        {
            bar2.GetComponent<Image>().color = new Color32(255, 236, 100, 255);
        }

        if (bar2.transform.localScale.y > 0.7f)
        {
            bar2.GetComponent<Image>().color = new Color32(69, 171, 97, 255);
        }
    }


    public void StartCount()
    {
        int ranTime = Random.Range(28, 41);
        LeanTween.scaleY(bar2, 0, ranTime);
    }

    public void StopCount()
    {
        LeanTween.cancel(bar2);
    }
}
