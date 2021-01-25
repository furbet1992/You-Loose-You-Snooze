using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //image moves left by 'x' amount 
    // have an list of the images. it should ge in order

    public List<GameObject> images = new List<GameObject>();

    private GraphicRaycaster ray;
    private RaycastHit hit;
    //public Camera cam;

    [SerializeField]
    int offset; 
    


    private void Start()
    {
        ray = GetComponent<GraphicRaycaster>(); 
    }
    // Update is called once per frame
    public void LeftClick()
    {
        //if (Input.GetKeyDown(KeyCode.K))
        //{

            foreach (GameObject i in images)
            {
                i.transform.position += new Vector3(-offset,0,0);
            }
        //}
    }

    public void RightClick()
    {
        foreach (GameObject n in images)
        {
            n.transform.position += new Vector3(offset, 0, 0);
        }
    }

    //public void MinigameSelection()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        ray = 
    //        if (Physics.Raycast(ray, out hit))
    //        {
    //            if(hit.)
    //        }
    //    }
    //}
}
