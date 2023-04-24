using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int Coin = 0;
    [SerializeField] Text CoinText;
    [SerializeField] Text GameOverText;
    public int MaxHeart = 3;
    [SerializeField] GameObject[] Hearts=new GameObject[3];
    [SerializeField] GameObject gameover;

    public int NoodleNum;
    public int SoupNum;
    public int ToppingNum;
    public int[] ToppingArray = new int[4];
    [SerializeField] Text NoodleText;
    [SerializeField] Text SoupText;
    [SerializeField] GameObject[] Toppings;
    [SerializeField] private AudioSource gameoversound;

    public int[] Menu = new int[6];
    public List<int> Guest1 = new List<int>();

    
    /// /////////////////////////////////////
 

    public int NoodleNum2;
    public int SoupNum2;
    public int ToppingNum2;
    public int[] ToppingArray2 = new int[4];
    [SerializeField] Text NoodleText2;
    [SerializeField] Text SoupText2;
    [SerializeField] GameObject[] Toppings2;

    public int[] Menu2 = new int[6];
    public List<int> Guest2 = new List<int>();

    /// /////////////////////////////////////


    public int NoodleNum3;
    public int SoupNum3;
    public int ToppingNum3;
    public int[] ToppingArray3 = new int[4];
    [SerializeField] Text NoodleText3;
    [SerializeField] Text SoupText3;
    [SerializeField] GameObject[] Toppings3;

    public int[] Menu3 = new int[6];
    public List<int> Guest3 = new List<int>();

    private void Start()
    {      
        MakeMenu();
        MakeMenu2();
        MakeMenu3();
        Menu = new int[] { 2, 2, 2, 2, 2, 2 };
        Menu2 = new int[] { 2, 2, 2, 2, 2, 2 };
        Menu3 = new int[] { 2, 2, 2, 2, 2, 2 };

    }
    public void AddCoin(int coin)
    {
        Coin += coin;
        if(Coin<=0)
        {
            CoinText.text = "00000";
            GameOverText.text = "00000";
        }

        else
        {
            CoinText.text = $"{Coin}";
            GameOverText.text = $"{Coin}";
        }
        
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

    public void MakeMenu2()
    {

        #region
        Guest2.RemoveAll(x => x < 10);
        Menu2 = new int[] { 2, 2, 2, 2, 2, 2 };
        NoodleNum2 = Random.Range(1, 4);
        Guest2.Add(NoodleNum2);
        SoupNum2 = Random.Range(1, 5);
        Guest2.Add(SoupNum2);
        for (int i = 0; i < 4; i++)
        {
            ToppingNum2 = Random.Range(1, 3);
            ToppingArray2[i] = ToppingNum2;
        }

        if (ToppingArray2[0] == 2 && ToppingArray2[1] == 2 && ToppingArray2[2] == 2 && ToppingArray2[3] == 2)
        {
            int num2 = Random.Range(0, 4);
            ToppingArray2[num2] = 1;
        }

        for (int i = 0; i < 4; i++)
        {
            Guest2.Add(ToppingArray2[i]);
        }

        if (NoodleNum2 == 1)
        {
            NoodleText2.text = "   ´ú ÀÍÈû";
        }

        if (NoodleNum2 == 2)
        {
            NoodleText2.text = "Àû´çÈ÷ ÀÍÈû";
        }

        if (NoodleNum2 == 3)
        {
            NoodleText2.text = "   Ç« ÀÍÈû";
        }

        if (SoupNum2 == 1)
        {
            SoupText2.text = "¼Ò±Ý ¶ó¸à";
        }

        if (SoupNum2 == 2)
        {
            SoupText2.text = "µÈÀå ¶ó¸à";
        }

        if (SoupNum2 == 3)
        {
            SoupText2.text = "°£Àå ¶ó¸à";
        }

        if (SoupNum2 == 4)
        {
            SoupText2.text = "¸Å¿î ¶ó¸à";
        }

        //////////////////////////////////////////

        if (ToppingArray2[0] == 1)
        {
            Toppings2[0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings2[0].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
        }

        if (ToppingArray2[1] == 1)
        {
            Toppings2[1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings2[1].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
        }

        if (ToppingArray2[2] == 1)
        {
            Toppings2[2].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings2[2].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
        }

        if (ToppingArray2[3] == 1)
        {
            Toppings2[3].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings2[3].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
        }
        #endregion

    }

    public void MakeMenu3()
    {
        #region
        Guest3.RemoveAll(x => x < 10);
        Menu3 = new int[] { 2, 2, 2, 2, 2, 2 };
        NoodleNum3 = Random.Range(1, 4);
        Guest3.Add(NoodleNum3);
        SoupNum3= Random.Range(1, 5);
        Guest3.Add(SoupNum3);
        for (int i = 0; i < 4; i++)
        {
            ToppingNum3 = Random.Range(1, 3);
            ToppingArray3[i] = ToppingNum3;
        }

        if (ToppingArray3[0] == 2 && ToppingArray3[1] == 2 && ToppingArray3[2] == 2 && ToppingArray3[3] == 2)
        {
            int num3 = Random.Range(0, 4);
            ToppingArray3[num3] = 1;
        }

        for (int i = 0; i < 4; i++)
        {
            Guest3.Add(ToppingArray3[i]);
        }

        if (NoodleNum3 == 1)
        {
            NoodleText3.text = "   ´ú ÀÍÈû";
        }

        if (NoodleNum3 == 2)
        {
            NoodleText3.text = "Àû´çÈ÷ ÀÍÈû";
        }

        if (NoodleNum3 == 3)
        {
            NoodleText3.text = "   Ç« ÀÍÈû";
        }

        if (SoupNum3 == 1)
        {
            SoupText3.text = "¼Ò±Ý ¶ó¸à";
        }

        if (SoupNum3 == 2)
        {
            SoupText3.text = "µÈÀå ¶ó¸à";
        }

        if (SoupNum3 == 3)
        {
            SoupText3.text = "°£Àå ¶ó¸à";
        }

        if (SoupNum3 == 4)
        {
            SoupText3.text = "¸Å¿î ¶ó¸à";
        }

        //////////////////////////////////////////

        if (ToppingArray3[0] == 1)
        {
            Toppings3[0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings3[0].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
        }

        if (ToppingArray3[1] == 1)
        {
            Toppings3[1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings3[1].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
        }

        if (ToppingArray3[2] == 1)
        {
            Toppings3[2].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings3[2].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
        }

        if (ToppingArray3[3] == 1)
        {
            Toppings3[3].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }

        else
        {
            Toppings3[3].GetComponent<Image>().color = new Color32(255, 255, 255, 60);
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
            gameover.SetActive(true);
            gameoversound.Play();
            Coin = 0;
            Invoke(nameof(StopTime), 0.7f);
        }
    }

    private void StopTime()
    {
        Time.timeScale = 0;
    }


}
