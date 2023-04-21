using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.UI;

public class Temperature : MonoBehaviour
{
    public GameObject bar;
    public int time;
    [SerializeField] Button Pot;
    public int num;
    public GameObject water;
    public GameObject net;
    public GameObject noodles;
    public Button[] abled;
    public Button[] disabled;   
    [SerializeField] private GameObject temperatureUnder;
    [SerializeField] private GameObject temperatureInside;
    [SerializeField] private GameObject dragPrevent;
    [SerializeField] private GameObject boilPrevent;
    [SerializeField] private Dialogue dialogue;
    [SerializeField] private AudioSource watersplash;
    [SerializeField] private AudioSource waterboiling;
    [SerializeField] private GameObject boil;
    public GameManager gamemanager;

    void Start()
    {        
        Pot.onClick.AddListener(AnimateBar);
        dragPrevent.SetActive(true);

        for (int i=0;i<disabled.Length;i++)
        {
            disabled[i].enabled = false;
        }

        
        
    }

    private void Update()
    {
        if (transform.localScale.y <= 0.3f)
        {
            temperatureUnder.GetComponent<Image>().color = new Color32(69, 118, 171, 255);
            temperatureInside.GetComponent<Image>().color = new Color32(69, 118, 171, 255);
        }

        if (transform.localScale.y > 0.3f)
        {
            temperatureUnder.GetComponent<Image>().color = new Color32(69, 171, 97, 255);
            temperatureInside.GetComponent<Image>().color = new Color32(69, 171, 97, 255);
        }

        if (transform.localScale.y > 0.7f)
        {
            temperatureUnder.GetComponent<Image>().color = new Color32(255, 96, 96, 255);
            temperatureInside.GetComponent<Image>().color = new Color32(255, 96, 96, 255);
        }
    }
    // Update is called once per frame
    public void AnimateBar()
    {        
        num++;
        waterboiling.Play();
        boil.SetActive(true);
        if (num == 1)
        {
            LeanTween.scaleY(bar, 1, time);
            
        }

        else if (num > 1)
        {
           

            LeanTween.cancel(bar);
            net.SetActive(true);
            water.SetActive(true);
            waterboiling.Pause();
            watersplash.Play();
            boil.SetActive(false);
            if (dialogue.Active()&&!dialogue.inActive)
            {                

                if (transform.localScale.y > 0.3f && transform.localScale.y < 0.7f)
                {
                    dialogue.NoodleSuccess();
                    Invoke(nameof(WaitforSec), 1.0f);
                }

                else
                {
                    num =0;
                    dialogue.NoodleFailure();
                    Invoke(nameof(WaitforNoodle), 1.0f);
                }
            }

            else 
            {
                if (transform.localScale.y <= 0.3f)
                {
                    gamemanager.Menu[0] = 1;
                    gamemanager.Menu2[0] = 1;
                    gamemanager.Menu3[0] = 1;

                }

                else if (transform.localScale.y > 0.3f && transform.localScale.y < 0.7f)
                {
                    gamemanager.Menu[0] = 2;
                    gamemanager.Menu2[0] = 2;
                    gamemanager.Menu3[0] = 2;
                }

                else if(transform.localScale.y > 0.7f)
                {
                    gamemanager.Menu[0] = 3;
                    gamemanager.Menu2[0] = 3;
                    gamemanager.Menu3[0] = 3;
                }

                Invoke(nameof(WaitforSec), 1.0f);
            }

        }

    }

    void WaitforNoodle()
    {        
        net.SetActive(false);
        water.SetActive(false);
        

        for (int i = 0; i < 4; i++)
        {
            disabled[i].enabled = false;
        }

        for (int i = 0; i < abled.Length; i++)
        {
            abled[i].enabled = true;
        }

        temperatureUnder.GetComponent<Image>().color = new Color32(69, 118, 171, 255);
        temperatureInside.GetComponent<Image>().color = new Color32(69, 118, 171, 255);
        bar.transform.localScale = new Vector3(1, 0, 1);

    }

    void WaitforSec()
    {
        num = 0;
        noodles.SetActive(true);
        net.SetActive(false);
        water.SetActive(false);
        boilPrevent.SetActive(true);

        for (int i = 0; i < 4; i++)
        {
            disabled[i].enabled = true;
        }

        for (int i = 0; i < abled.Length; i++)
        {
            abled[i].enabled = false;
        }

        temperatureUnder.GetComponent<Image>().color = new Color32(69, 118, 171, 255);
        temperatureInside.GetComponent<Image>().color = new Color32(69, 118, 171, 255);
        bar.transform.localScale = new Vector3(1, 0, 1);        
    }

}
