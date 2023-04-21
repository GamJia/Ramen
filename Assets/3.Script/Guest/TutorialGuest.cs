using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialGuest : MonoBehaviour
{
    [SerializeField] private Dialogue dialogue;
    [SerializeField] private GameManager gamemanager;
    [SerializeField] private SpriteRenderer spriterenderer;
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject tutorial;
    [SerializeField] private FirstGuest firstguest;
    [SerializeField] private SecondGuest secondguest;
    [SerializeField] private ThirdGuest thirdguest;
    [SerializeField] private Animator guestAnimation;
    [SerializeField] private AudioSource correct;

    private void Start()
    {
        spriterenderer.GetComponent<SpriteRenderer>();

    }
    public void DialogueFalse()
    {
        correct.Play();
        dialogue.inActive = true;
        gamemanager.AddCoin(10000);
        guestAnimation.SetBool("isRight", true);
        menu.SetActive(false);
        StopCoroutine("FadeOut");
        StartCoroutine("FadeOut");
        Invoke(nameof(FirstMove), 1.2f);
        Invoke(nameof(SecondMove), 7.2f);
        Invoke(nameof(ThirdMove), 13.2f);

    }

    IEnumerator FadeOut()
    {
        for (float f = 1f; f >= -0.05f; f -= 0.05f)
        {
            Color c = spriterenderer.material.color;
            c.a = f;
            spriterenderer.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }

        Invoke(nameof(TutorialInactive), 2.2f);
    }

    private void FirstMove()
    {
        firstguest.SelectCharactor();
    }

    private void SecondMove()
    {
        secondguest.SelectCharactor();
    }

    private void ThirdMove()
    {
        thirdguest.SelectCharactor();
    }

    private void TutorialInactive()
    {
        tutorial.SetActive(false);
    }
}
