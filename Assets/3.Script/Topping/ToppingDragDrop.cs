using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToppingDragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private GameObject topping;
    [SerializeField] Sprite[] swapImage = new Sprite[2];
    [SerializeField] private GameObject ramen;
    public GameObject[] ToppingTop = new GameObject[4];
    public static Vector2 DefaultPos;
    public Button[] disabled;
    [SerializeField] private GameObject dragPrevent;
    
    [SerializeField] private Dialogue dialogue;
    [SerializeField] private SoupDragDrop soupdragdrop;
    public GameManager gamemanager;




    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        DefaultPos = this.transform.position;
        
    }

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)canvas.transform, pointerData.position, canvas.worldCamera, out position);
        transform.position = canvas.transform.TransformPoint(position);

        if (transform.position.x > -0.7f && transform.position.x < 2.4f && transform.position.y < 0.6f && transform.position.y > -2.9f)
        {
            ramen.GetComponent<Image>().sprite = swapImage[1];
            ramen.transform.localScale = new Vector3(0.9259259f, 0.9259259f, 0.9259259f);            
        }

        else
        {
            ramen.GetComponent<Image>().sprite = swapImage[0];
            ramen.transform.localScale = new Vector3(0.9259259f, 0.9259259f, 0.9259259f); 
        }
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {        
        if(transform.position.x>-0.7f&&transform.position.x<2.4f&&transform.position.y<0.6f&&transform.position.y>-2.9f)
        {            
            if (topping.gameObject.CompareTag("Chashu"))
            {
                ToppingTop[0].SetActive(true);
                disabled[0].enabled = false;
                dragPrevent.SetActive(false);
                if (dialogue.inActive)
                {
                    gamemanager.Menu[2] = 1;
                }
            }

            if (topping.gameObject.CompareTag("Tamago"))
            {
                ToppingTop[1].SetActive(true);
                disabled[1].enabled = false;
                dragPrevent.SetActive(false);
                if (dialogue.inActive)
                {
                    gamemanager.Menu[3] = 1;
                }

            }

            if(topping.gameObject.CompareTag("Naruto"))
            {
                ToppingTop[2].SetActive(true);
                disabled[2].enabled = false;                
                dragPrevent.SetActive(false);

                if (dialogue.inActive)
                {
                    gamemanager.Menu[4] = 1;
                }
                
            }

            if(topping.gameObject.CompareTag("Nori"))
            {
                ToppingTop[3].SetActive(true);
                disabled[3].enabled = false;               
                dragPrevent.SetActive(false);
                if(dialogue.inActive)
                {
                    gamemanager.Menu[5] = 1;
                }

            }



        }

        if(ToppingTop[0].activeSelf&&ToppingTop[1].activeSelf&& ToppingTop[2].activeSelf&& ToppingTop[3].activeSelf&&!dialogue.inActive)
        {
            soupdragdrop.isTopping = true;
            dialogue.ToppingSuccess();
        }

        ramen.GetComponent<Image>().sprite = swapImage[0];
        ramen.transform.localScale = new Vector3(0.9259259f, 0.9259259f, 0.9259259f); 
        topping.SetActive(false);
        this.transform.position = DefaultPos;        

    }



}
