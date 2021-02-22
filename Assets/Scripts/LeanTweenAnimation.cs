using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenAnimation : MonoBehaviour
{

    // public GameObject rhymeWord;

    Vector3 originalPos;

    void Start()
    {
        originalPos = this.gameObject.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RhymeWordTween()
    {
        //LeanTween.scale(gameObject, new Vector3(0, 0, 0), 2f).setEase(LeanTweenType.easeOutElastic); 
        
        LeanTween.scale(gameObject, new Vector3(3, 5, 3), 2f).setEasePunch();        
        // LeanTween.scale(gameObject, new Vector3(0, 0, 0), 2f).setOnComplete(DestroyMe);
        //LeanTween.alphaText(rhymeWord.GetComponent<RectTransform>(), 10f, 10f);
        // LeanTween.value(rhymeWord)
    }

    public void TweenUIBox()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f).setOnComplete(DestroyMe);
    }

    public void DestroyMe()
    {
        Destroy(gameObject); 
    }
}
