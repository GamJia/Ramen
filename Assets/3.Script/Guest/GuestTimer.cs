using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.UI;

public class GuestTimer : MonoBehaviour
{
    [SerializeField] public GameObject bar;
    [SerializeField] private FirstGuest firstguest;

    private void Update()
    {
        if (bar.transform.localScale.y == 0)
        {
            firstguest.CheckAnswer();
        }

        if (bar.transform.localScale.y <= 0.3f)
        {
            bar.GetComponent<Image>().color = new Color32(255, 96, 96, 255);
        }

        if (bar.transform.localScale.y > 0.3f)
        {
            bar.GetComponent<Image>().color = new Color32(255, 236, 100, 255);
        }

        if (bar.transform.localScale.y > 0.7f)
        {
            bar.GetComponent<Image>().color = new Color32(69, 171, 97, 255);
        }
    }

 
    public void StartCount()
    {
        int ranTime = Random.Range(28, 41);
        LeanTween.scaleY(bar, 0, ranTime);
    }

    public void StopCount()
    {
        LeanTween.cancel(bar);
    }
}
