using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenAnimation : MonoBehaviour
{

    // public GameObject rhymeWord;

    Vector3 originalPos;
    public GameObject infor; 

    // 








    void Start()
    {
        originalPos = this.gameObject.transform.position; 
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
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f);//.setOnComplete(DestroyMe);
        LeanTween.move(gameObject, infor.transform.position, 0.5f); 
    }

    public void DestroyMe()
    {
        Destroy(gameObject); 
    }

    public void TweenOut()
    {
        LeanTween.scale(gameObject, new Vector3(1, 1, 1), 1f);
        LeanTween.move(gameObject,originalPos, 0.5f);
    }

}
