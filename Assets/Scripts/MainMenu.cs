using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ToTheGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ToThePlanetarium()
    {
        SceneManager.LoadScene(2);
    }
    
    public void ToSettings()
    {
        SceneManager.LoadScene(3);
    }


    public void Quit()
    {
        Application.Quit();
    }
}
