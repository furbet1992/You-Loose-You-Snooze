using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MiniGameSelect : MonoBehaviour
{
    GraphicRaycaster rayCaster;
    PointerEventData pointerEventData;
    EventSystem      eventSystem;

    GameManager gameManager;

    public Rhyme rhymeWords;
    public LeanTweenAnimation leanTA;

    public AudioSource boing; 


    void Start()
    {
        rayCaster = GetComponent<GraphicRaycaster>();
        eventSystem = GetComponent<EventSystem>();
        gameManager = GetComponent<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointerEventData = new PointerEventData(eventSystem);
            pointerEventData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();

            rayCaster.Raycast(pointerEventData, results);

            foreach (RaycastResult result in results)
            {
                if(result.gameObject.name == "MAIN WORD")
                {
                    //Debug.Log("detect"); 
                    rhymeWords.GetComponent<Rhyme>().ChooseWord();
                    leanTA.GetComponent<LeanTweenAnimation>().RhymeWordTween();
                    boing.Play(); 
                }


               //WheelFortune
                //if(result.gameObject.name == "WheelFortune")
                //{                    
                //    gameManager.WheelFortune(); 
                //}
                ////Egg
                //if (result.gameObject.name == "Egg")
                //{
                //    gameManager.Egg();
                //}
                ////Card
                //if (result.gameObject.name == "Card")
                //{
                //    gameManager.Card();
                //}
                ////Rhythm
                //if (result.gameObject.name == "Rhythm")
                //{
                //    gameManager.Rhythm();
                //}

            }
        }
    }
}
