using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //Restart
    //
    //UI that shows player 

    // Update is called once per frame
    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void HomeScene()
    {
        SceneManager.LoadScene(0);
    }

    public void WheelFortune()
    {
        SceneManager.LoadScene(1);
    }

    public void Egg()
    {
        SceneManager.LoadScene(2);
    }

    public void Card()
    {
        SceneManager.LoadScene(3);
    }

    public void Rhythm()
    {
        SceneManager.LoadScene(4);
    }


}
