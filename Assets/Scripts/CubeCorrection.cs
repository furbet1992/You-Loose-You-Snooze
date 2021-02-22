using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class CubeCorrection : MonoBehaviour
{

    public List<GameObject> cubeList = new List<GameObject>();

    public GameObject randomCube;
    public Camera cam;

    private Ray ray;
    private RaycastHit hit;


    //Text or Image to say you lost
    public Text loseText; 



    void Start()
    {
        randomCube = cubeList[Random.Range(0, 14)];
        Debug.Log(randomCube.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == randomCube)
                {
                    Debug.Log("BADLUCK");
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
                    Vibration(); 
                    //animation 
                    loseText.text = "Cuc'ed ";
                    StartCoroutine(Loser());
                }
                else
                {
                    hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
                    //Destroy(hit.collider.gameObject);
                }
            }
        }
        Debug.DrawRay(cam.transform.position, Vector3.forward * 10, Color.red);
    }

    IEnumerator Loser()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }


    void Vibration()
    {
        Handheld.Vibrate();
        Debug.Log("Vibrate"); 
    }
}
 


