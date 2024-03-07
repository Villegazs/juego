using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeConCoroutine : FadeSinCoroutine
{

    //Sobrecarga especializar un metodo
    // Start is called before the first frame update
    private MMF_Player feedback;
    void Start()
    {
        
    }

    public override void FadeIn()
    {
        feedback?.PlayFeedbacks();
        StartCoroutine(FadeInCoroutine());
    }

    private IEnumerator FadeInCoroutine() 
    {

        _spriteRenderer = setPlayer();
        
        Color c = _spriteRenderer.color;
        for (float alpha = 0; alpha <= 1.0f; alpha += 0.1f)
        {
            c.a = alpha;
            _spriteRenderer.color = c;

            yield return null;
        }
    }

    private IEnumerator FadeOutCoroutine()
    {

        _spriteRenderer = setPlayer();

        Color c = _spriteRenderer.color;
        for (float alpha = 0; alpha <= 1.0f; alpha -= 0.1f)
        {
             
            //Debug.Log(
            c.a = alpha;
            _spriteRenderer.color = c;
            //yield return new WaitForSeconds(0.1f);
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
