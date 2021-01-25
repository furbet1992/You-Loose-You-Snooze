using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class WheelInformation : MonoBehaviour
{
    public Text blueText;
    public Text redText; 


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "blueTag")
        {
            blueText.text = "Everyone Drinks"; 
        }

        if (other.gameObject.tag == "redTag")
        {
            blueText.text = "You and Person On Right Drinks";
        }
    }


}
