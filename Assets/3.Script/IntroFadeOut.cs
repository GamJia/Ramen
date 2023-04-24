using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroFadeOut : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriterenderer;
    // Start is called before the first frame update
    void Start()
    {
        StopCoroutine("FadeOut");
        StartCoroutine("FadeOut");
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
        
    }

}
