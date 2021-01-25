using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 

public class Egg : MonoBehaviour
{
    //the chosen egg out of random.range (0,20)
    public int correctEgg;
    //the current number
    public int currentEgg=0; 

    private Ray ray;
    private RaycastHit hit;
    public Camera cam;

    //public GameObject upperEgg;
    public GameObject poopEgg;
    public GameObject eggPos; 

    //text of current score
    public Text currentScore;
    //text of losing
    public Text cuced;

    Vector3 oriPos; 


    private void Start()
    {
        oriPos = this.gameObject.transform.position;
        correctEgg = Random.Range(1, 20); 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                currentEgg++;
                Instantiate(poopEgg, eggPos.transform.position, Quaternion.identity); 
                //each click will represent the egg cracking. 
                Debug.Log(currentEgg); 
            }
        }

        if(currentEgg == correctEgg)
        {
            //egg animated to completely breaking.
            //cuced.text = cuced.ToString(); 
           // upperEgg.transform.position = new Vector3(transform.position.x, 2f, transform.position.z); 
            StartCoroutine(resetGame());
            
        }

        currentScore.text = currentEgg.ToString(); 
    }

    IEnumerator resetGame()
    {
        yield return new WaitForSeconds(1);
        Start();
        currentEgg = 0;
        gameObject.transform.position = oriPos; 
       
    }
}
