using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    //spinner
    float rotSpeed = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            this.rotSpeed = 10; 
        }

        transform.Rotate(0, this.rotSpeed, 0);

        this.rotSpeed *= 0.98f; 
    }
}
