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
    
    public void ToTheMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ToThePlanetarium()
    {
        SceneManager.LoadScene(2);
    }
    
    public void OpenSettings()
    {
        SceneManager.LoadScene(3);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
