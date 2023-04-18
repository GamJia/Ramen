using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Coin = 0;
    [SerializeField] Text CoinText;
    public int NoodleNum;
    public int SoupNum;
    public int ToppingNum;
    public int[] ToppingArray = new int[4];
    [SerializeField] Text NoodleText;
    [SerializeField] Text SoupText;
    [SerializeField] GameObject[] Toppings;

    [SerializeField] GameObject[] Hearts=new GameObject[3];
    public int MaxHeart = 3;
    public int[] Menu = new int[6];
    public List<int> Guest1 = new List<int>();

    private void Start()
    {      
        MakeMenu();
        Menu = new int[] { 2, 2, 2, 2, 2, 2 };
    }
    public void AddCoin(int coin)
    {
        Coin += coin;
        CoinText.text = $"{Coin}";
    }
    public void MakeMenu()
    {
        #region
        Guest1.RemoveAll(x => x < 10);
        Menu = new int[] { 2, 2, 2, 2, 2, 2 };
        NoodleNum = Random.Range(1, 4);
        Guest1.Add(NoodleNum);
        SoupNum = Random.Range(1, 5);
        Guest1.Add(SoupNum);
        for (int i=0;i<4;i++)
        {
            ToppingNum = Random.Range(1, 3);
            ToppingArray[i] = ToppingNum;
        }

        if(ToppingArray[0]==2&& ToppingArray[1] == 2&& ToppingArray[2] == 2&& ToppingArray[3] == 2)
        {
            int num= Random.Range(0, 4);
            ToppingArray[num] = 1;
        }

        for(int i=0;i<4;i++)
        {
            Guest1.Add(ToppingArray[i]);
        }

        if (NoodleNum == 1)
        {
            NoodleText.text = "   ´ú ÀÍÈû";
        }

        if (NoodleNum == 2)
        {
            NoodleText.text = "Àû´çÈ÷ ÀÍÈû";
        }

        if (NoodleNum == 3)
        {
            NoodleText.text = "   Ç« ÀÍÈû";
        }

        if (SoupNum == 1)
        {
            SoupText.text = "¼Ò±Ý ¶ó¸à";
        }

        if (SoupNum == 2)
        {
            SoupText.text = "µÈÀå ¶ó¸à";
        }

        if (SoupNum == 3)
        {
            SoupText.text = "°£Àå ¶ó¸à";
        }

        if (SoupNum == 4)
        {
            SoupText.text = "¸Å¿î ¶ó¸à";
        }

        //////////////////////////////////////////

        if(ToppingArray[0]==1)
        {
            Toppings[0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings[0].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
        }

        if (ToppingArray[1] == 1)
        {
            Toppings[1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings[1].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
        }

        if (ToppingArray[2]==1)
        {
            Toppings[2].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings[2].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
        }

        if (ToppingArray[3] == 1)
        {
            Toppings[3].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings[3].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
        }
        #endregion

    }

    public void Heart(int heart)
    {
        MaxHeart += heart;
        if(MaxHeart==2)
        {
            Hearts[2].SetActive(false);
        }

        if(MaxHeart==1)
        {
            Hearts[1].SetActive(false);
        }

        if (MaxHeart == 0)
        {
            Hearts[0].SetActive(false);
        }
    }


}
