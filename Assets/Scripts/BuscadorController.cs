using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuscadorController : MonoBehaviour
{
    

    //public static event Action<GameObject> ActiveThisIsle;
    //public static event Action<GameObject> ActivedIsle;
    // Pag buscador
    public GameObject islePage;
    public GameObject alimentPage;
    public GameObject typePage;
    public GameObject alienNamePage;

    // Alien Buttons 
    public GameObject tekni;
    public GameObject equus;
    public GameObject scavenger;
    public GameObject mekkari;
    public GameObject[] alienNameButtons;

    // Alien scenes prefabs
    public GameObject tekniScene;
    public GameObject equusScene;
    public GameObject scavengerScene;
    public GameObject mekkariScene;
    public GameObject actualScene;
    public GameObject[] scenes;

    //Extra Buttons
    public GameObject turnOn;


    private void Start()
    {
        InstanceScriptArray();
    }

    // MainPage controller
    public void Nombre()
    {
        alienNamePage.SetActive(true);
        tekni.SetActive(true);
        equus.SetActive(true);
        scavenger.SetActive(true);
        mekkari.SetActive(true);
    }

    public void Alimento()
    {
        alimentPage.SetActive(true);
    }
    public void Tipo()
    {
        typePage.SetActive(true);
    }
    public void Isla()
    {
        islePage.SetActive(true);
    }

    public void ExitBuscador()
    {
        islePage.SetActive(false);
        alimentPage.SetActive(false);
        typePage.SetActive(false);
        alienNamePage.SetActive(false);

        foreach (var button in alienNameButtons)
        {
            button.SetActive(false);
        }
    }

    // subpages controller
    public void AlienPageActived(int alienID)
    {
        CheckActualScene().SetActive(false);
        scenes[alienID].SetActive(true);
    }

    public void ShowAlienMatchingFilter(int alienID)
    {
        alienNamePage.SetActive(true);
        alienNameButtons[alienID].SetActive(true);
    }

    public void InstanceScriptArray()
    {
        scenes = new GameObject[4] { tekniScene, equusScene, scavengerScene, mekkariScene };
        alienNameButtons = new GameObject[4] { tekni, equus, scavenger, mekkari };
    }

    // alien scene change
    public GameObject CheckActualScene()
    {

        foreach (GameObject scene in scenes)
        {
            if (scene.activeInHierarchy == true)
            {
                actualScene = scene;
            }
        }
        return actualScene;
    }

    public void TurnOnDex()
    {
        turnOn.SetActive(false);
        scenes[0].SetActive(true);
    }
}
