using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoupSelect : MonoBehaviour
{
    [SerializeField] Button[] Selects;
    [SerializeField] GameObject[] Soups = new GameObject[4];
    public Button[] disabled;
    [SerializeField] GameObject noodle;
    SoupDragDrop soupdragdrop;
    [SerializeField] private Dialogue dialogue;
    [SerializeField] private GameObject soupPrevent;
    [SerializeField] private GameObject toppingPrevent;
    [SerializeField] private GameObject dragPrevent;
    [SerializeField] private AudioSource waterpouring;
    public GameManager gamemanager;


    void Start()
    {                
        foreach (Button btn in Selects)
        {
            Button Select = btn;
            btn.onClick.AddListener(() => TaskOnClick(Select)); 
        }
        for(int i=0;i<Soups.Length;i++)
        {
            Soups[i].GetComponent<Image>().color = new Color32(255, 255, 255, 0);
        }

    }

    public void TaskOnClick(Button Select)
    {
        noodle.SetActive(false);
        noodle.transform.position = new Vector3(0.8f, -0.1f, 90.0f);
        waterpouring.Play();
        dragPrevent.SetActive(true);
        if (Select.gameObject.CompareTag("Salt"))
        {
            Soups[0].SetActive(true);
            Soups[1].SetActive(false);
            Soups[2].SetActive(false);
            Soups[3].SetActive(false);

            Soups[1].GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            Soups[2].GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            Soups[3].GetComponent<Image>().color = new Color32(255, 255, 255, 0);

            Invoke(nameof(WaitforSec), 1.0f);



            if (dialogue.Active() && !dialogue.inActive)
            {
                dialogue.SoupFailure();
                toppingPrevent.SetActive(true);
            }

            else
            {
                toppingPrevent.SetActive(false);
                gamemanager.Menu[1] = 1;
            }

        }

        if (Select.gameObject.CompareTag("Miso"))
        {
            Soups[0].SetActive(false);
            Soups[1].SetActive(true);
            Soups[2].SetActive(false);
            Soups[3].SetActive(false);

            Soups[0].GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            Soups[2].GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            Soups[3].GetComponent<Image>().color = new Color32(255, 255, 255, 0);

            Invoke(nameof(WaitforSec1), 1.0f);


            if (dialogue.Active() && !dialogue.inActive)
            {
                dialogue.SoupFailure();
                toppingPrevent.SetActive(true);
            }

            else
            {
                toppingPrevent.SetActive(false);
                gamemanager.Menu[1] = 2;
            }
        }

        if (Select.gameObject.CompareTag("Shoyu"))
        {
            Soups[0].SetActive(false);
            Soups[1].SetActive(false);
            Soups[2].SetActive(true);
            Soups[3].SetActive(false);

            Soups[0].GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            Soups[1].GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            Soups[3].GetComponent<Image>().color = new Color32(255, 255, 255, 0);

            Invoke(nameof(WaitforSec2), 1.0f);


            if (dialogue.Active()&& !dialogue.inActive)
            {
                dialogue.SoupFailure();
                toppingPrevent.SetActive(true);
            }

            else
            {
                toppingPrevent.SetActive(false);
                gamemanager.Menu[1] = 3;
            }
        }

        if (Select.gameObject.CompareTag("Rayu"))
        {
            Soups[0].SetActive(false);
            Soups[1].SetActive(false);
            Soups[2].SetActive(false);
            Soups[3].SetActive(true);

            Soups[0].GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            Soups[1].GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            Soups[2].GetComponent<Image>().color = new Color32(255, 255, 255, 0);

            Invoke(nameof(WaitforSec3), 1.0f);


            if (dialogue.Active() && !dialogue.inActive)
            {
                soupPrevent.SetActive(true);
                dialogue.SoupSuccess();
                toppingPrevent.SetActive(false);
            }

            else
            {
                toppingPrevent.SetActive(false);
                gamemanager.Menu[1] = 4;
            }
                       
        }

        for (int i = 0; i < disabled.Length; i++)
        {            
            disabled[i].enabled = true;
        }
    }

    public void WaitforSec()
    {
        Soups[0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);        
    }

    public void WaitforSec1()
    {
        Soups[1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        
    }

    public void WaitforSec2()
    {
        Soups[2].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        
    }

    public void WaitforSec3()
    {
        Soups[3].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        
    }
   
}
