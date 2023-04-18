using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DentedPixel;

public class FirstGuest : MonoBehaviour
{
    [SerializeField] private GameManager gamemanager;
    [SerializeField] private SpriteRenderer spriterenderer;
    [SerializeField] public GameObject guest;
    [SerializeField] public GameObject character;
    [SerializeField] public GameObject menu;
    public int[] answerArr = new int[6];
    public List<int> answerList = new List<int>();
    [SerializeField] private Animator guestAnimation;
    [SerializeField] private GuestTimer guesttimer;

    public static Vector2 DefaultPos;
    

    private void Start()
    {
        spriterenderer.GetComponent<SpriteRenderer>();
        DefaultPos = guest.transform.position;

    }

    public void Movement()
    {
        guesttimer.StartCount();
        character.SetActive(true);
        LeanTween.moveLocalX(guest, -621.741f, 3);
        Invoke(nameof(waitforsec),3.4f);
    }

    void waitforsec()
    {
        menu.SetActive(true);
    }


    public void CheckAnswer()
    {
        answerList.RemoveAll(x => x < 10);
        for (int i=0;i<answerArr.Length;i++)
        {
            answerArr[i] = gamemanager.Menu[i];
        }
        answerList.AddRange(answerArr);

        bool isEqual = answerArr.SequenceEqual(gamemanager.Guest1);

        if(isEqual)
        {
            Debug.Log("동일함");
            guestAnimation.SetBool("isRight", true);
            gamemanager.AddCoin(10000);
            StopCoroutine("FadeOut");
            StartCoroutine("FadeOut");
        }


        if (!isEqual)
        {
            Debug.Log("다름");
            guestAnimation.SetBool("isWrong", true);
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
        Invoke(nameof(ResetPosition),0.8f);
    }

    void ResetPosition()
    {
        guest.transform.position = DefaultPos;
        Invoke(nameof(ResetColor), 0.2f);
    }

    void ResetColor()
    {
        guestAnimation.SetBool("isRight", false);
        guestAnimation.SetBool("isWrong", false);
        Color c = spriterenderer.material.color;
        c.a = 1f;
        spriterenderer.material.color = c;
        menu.SetActive(false);
        Movement();
    }

    public void Reset()
    {
        
        for(int i=0;i<6;i++)
        {
            gamemanager.Menu[i] = 2;
        }

        gamemanager.MakeMenu();
    }
}
