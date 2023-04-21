using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.UI;

public class GuestTimer3 : MonoBehaviour
{
    [SerializeField] public GameObject bar3;
    [SerializeField] private ThirdGuest thirdguest;
    private void Update()
    {
        if (bar3.transform.localScale.y == 0)
        {
            thirdguest.CheckAnswer();
        }

        if (bar3.transform.localScale.y <= 0.3f)
        {  
            bar3.GetComponent<Image>().color = new Color32(255, 96, 96, 255);
        }  
            
        if (bar3.transform.localScale.y > 0.3f)
        {   
            bar3.GetComponent<Image>().color = new Color32(255, 236, 100, 255);
        }   
          
        if (bar3.transform.localScale.y > 0.7f)
        {   
            bar3.GetComponent<Image>().color = new Color32(69, 171, 97, 255);
        }
    }


    public void StartCount()
    {
        int ranTime = Random.Range(30, 41);
        LeanTween.scaleY(bar3, 0, ranTime);
    }

    public void StopCount()
    {
        LeanTween.cancel(bar3);
    }
}
