using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToppingSelect : MonoBehaviour
{
    [SerializeField] Button[] Selects;
    [SerializeField] GameObject[] Toppings=new GameObject[4];
    public Button[] disabled;

    void Start()
    {        

        foreach (Button btn in Selects)
        {
            Button Select = btn; 
            btn.onClick.AddListener(() => TaskOnClick(Select));
        }
      
    }


    void TaskOnClick(Button Select)
    {
        
        for (int i = 0; i < disabled.Length; i++)
        {
            disabled[i].enabled = false;
        }

        if (Select.gameObject.CompareTag("Chashu"))
        {
            Toppings[0].SetActive(true);
            Toppings[1].SetActive(false);
            Toppings[2].SetActive(false);
            Toppings[3].SetActive(false);
            
        }

        if (Select.gameObject.CompareTag("Tamago"))
        {
            Toppings[0].SetActive(false);
            Toppings[1].SetActive(true);
            Toppings[2].SetActive(false);
            Toppings[3].SetActive(false);
            
        }

        if (Select.gameObject.CompareTag("Naruto"))
        {
            Toppings[0].SetActive(false);
            Toppings[1].SetActive(false);
            Toppings[2].SetActive(true);
            Toppings[3].SetActive(false);
            
        }

        if (Select.gameObject.CompareTag("Nori"))
        {
            Toppings[0].SetActive(false);
            Toppings[1].SetActive(false);
            Toppings[2].SetActive(false);
            Toppings[3].SetActive(true);
            
        }

    }
}
