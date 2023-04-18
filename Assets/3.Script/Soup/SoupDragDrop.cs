using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SoupDragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private GameObject soup;
    public static Vector2 DefaultPos;
    [SerializeField] private GameObject shadow;
    public Button[] disabled;    
    [SerializeField] private Dialogue dialogue;
    public bool isTopping;

    public ToppingDragDrop toppingdragdrop;
    [SerializeField] private GameObject[] Soups;
    [SerializeField] private GameObject[] Toppings;
    [SerializeField] private GameObject boilPrevent;
    [SerializeField] private GameObject soupPrevent;
    [SerializeField] private TutorialGuest tutorial;
    [SerializeField] private GuestTimer guestTimer;

    [SerializeField] private FirstGuest firstguest;


    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        DefaultPos = this.transform.position;     
        

        if (dialogue.Active() && !dialogue.inActive)
        {            

            if(!isTopping)
            {
                dialogue.ToppingFailure();
                this.transform.position = DefaultPos;               
            }
        }

        else
        {
            for (int i = 0; i < disabled.Length; i++)
            {
                disabled[i].enabled = false;
            }
        }
    }

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;
        shadow.SetActive(false);
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)canvas.transform, pointerData.position, canvas.worldCamera, out position);
               
        transform.position = canvas.transform.TransformPoint(position);
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
       
        if (dialogue.Active()&& isTopping&&!dialogue.inActive)
        {
            if (transform.position.x > -8.4f && transform.position.x < -5.9f && transform.position.y < 3.4f && transform.position.y > 0.6f)
            {
                Debug.Log("¼Õ´Ô ¸¸Á·");
                tutorial.DialogueFalse();
                soupPrevent.SetActive(false) ;
                Invoke(nameof(WaitforNoodle), 0.1f);
                boilPrevent.SetActive(false);
                dialogue.Final();
            }

            else
            {
                this.transform.position = DefaultPos;
                shadow.SetActive(true);
            }
        }

        else if (dialogue.Active()&&!isTopping)
        {
            this.transform.position = DefaultPos;
            shadow.SetActive(true);            
        }

        else if (dialogue.inActive)
        {
            if (transform.position.x > -8.4f && transform.position.x < -5.9f && transform.position.y < 3.4f && transform.position.y > 0.6f)
            {
                guestTimer.StopCount();
                firstguest.CheckAnswer();
                guestTimer.bar.transform.localScale = new Vector3(1, 1, 1);
                Invoke(nameof(WaitforNoodle), 0.1f);
                boilPrevent.SetActive(false);
            }

            else
            {
                this.transform.position = DefaultPos;
                shadow.SetActive(true);
            }
           
        }

    }

    void WaitforNoodle()
    {
        this.transform.position = DefaultPos;
        shadow.SetActive(true);
        for(int i=0;i< Soups.Length;i++)
        {
            Soups[i].SetActive(false);
        }

        for (int i = 0; i < Soups.Length; i++)
        {
            Toppings[i].SetActive(false);
        }


    }
}
