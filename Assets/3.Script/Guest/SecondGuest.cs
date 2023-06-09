using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DentedPixel;

public class SecondGuest : MonoBehaviour
{
    [SerializeField] private GameManager gamemanager;
    [SerializeField] private SpriteRenderer spriterenderer;
    [SerializeField] public GameObject guest;
    [SerializeField] public GameObject[] character = new GameObject[6];
    [SerializeField] public GameObject menu;
    public int[] answerArr = new int[6];
    public List<int> answerList = new List<int>();
    [SerializeField] private GuestTimer2 guesttimer;
    [SerializeField] private Animator guestAnimator;
    [SerializeField] private AudioSource correct;
    [SerializeField] private AudioSource wrong;
    public int ran;


    public static Vector2 DefaultPos;


    private void Start()
    {
        DefaultPos = guest.transform.position;

    }


    public void SelectCharactor()
    {
        ran = Random.Range(0, 6);
        guesttimer.transform.localScale = new Vector3(1, 1, 1);
        Invoke(nameof(SetCharacter), 0.2f);
    }

    public void SetCharacter()
    {
        guestAnimator = character[ran].GetComponent<Animator>();
        spriterenderer = character[ran].GetComponent<SpriteRenderer>();
        character[ran].SetActive(true);
        Invoke(nameof(Movement), 1.4f);
    }

    public void Movement()
    {
        guesttimer.StartCount();
        LeanTween.moveLocalX(guest, 14f, 5);
        Invoke(nameof(waitforsec), 5.4f);
    }

    void waitforsec()
    {
        menu.SetActive(true);
    }


    public void CheckAnswer()
    {
        answerList.RemoveAll(x => x < 10);

        if(guesttimer.bar2.transform.localScale.y==0)
        {
            for (int i = 0; i < answerArr.Length; i++)
            {
                answerArr[i] = 5;
            }
        }

        else
        {
            for (int i = 0; i < answerArr.Length; i++)
            {
                answerArr[i] = gamemanager.Menu2[i];
            }
        }
        
        answerList.AddRange(answerArr);

        bool isEqual = answerArr.SequenceEqual(gamemanager.Guest2);

        if (isEqual)
        {
            correct.Play();
            guestAnimator.SetBool("isRight", true);
            gamemanager.AddCoin(10000);
            StopCoroutine("FadeOut");
            StartCoroutine("FadeOut");
        }


        if (!isEqual)
        {
            wrong.Play();
            guestAnimator.SetBool("isWrong", true);
            gamemanager.AddCoin(-5000);
            gamemanager.Heart(-1);
            StopCoroutine("FadeOut");
            StartCoroutine("FadeOut");
        }
               

        Invoke(nameof(Reset), 0.1f);
    }
      

    IEnumerator FadeOut()
    {
        menu.SetActive(false);

        for (float f = 1f; f >= -0.05f; f -= 0.05f)
        {
            Color c = spriterenderer.material.color;
            c.a = f;
            spriterenderer.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
        Invoke(nameof(ResetPosition), 0.8f);
    }

    void ResetPosition()
    {
        guesttimer.bar2.transform.localScale = new Vector3(1, 1, 1);
        guest.transform.position = DefaultPos;
        Invoke(nameof(ResetColor), 0.2f);
    }

    void ResetColor()
    {
        guestAnimator.SetBool("isRight", false);
        guestAnimator.SetBool("isWrong", false);
        Color c = spriterenderer.material.color;
        c.a = 1f;
        spriterenderer.material.color = c;
        character[ran].SetActive(false);
        menu.SetActive(false);
        SelectCharactor();

    }

    public void Reset()
    {

        for (int i = 0; i < 6; i++)
        {
            gamemanager.Menu[i] = 2;
            gamemanager.Menu2[i] = 2;
            gamemanager.Menu3[i] = 2;
        }
        
        gamemanager.MakeMenu2();


    }
}
