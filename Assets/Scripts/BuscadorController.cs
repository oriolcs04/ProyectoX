using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuscadorController : MonoBehaviour
{
    private void Start()
    {
        InstanceScriptArray();
    }

    //public static event Action<GameObject> ActiveThisIsle;
    //public static event Action<GameObject> ActivedIsle;
    // Pag buscador
    public GameObject IslePage;
    public GameObject AlimentPage;
    public GameObject TypePage;
    public GameObject AlienNamePage;

    // Alien Buttons 
    public GameObject Tekni;
    public GameObject Equus;
    public GameObject Scavenger;
    public GameObject Mekkari;
    public GameObject[] AlienNameButtons;

    // Alien scenes prefabs
    public GameObject TekniScene;
    public GameObject EquusScene;
    public GameObject ScavengerScene;
    public GameObject MekkariScene;
    public GameObject ActualScene;
    public GameObject[] Scenes;

    // MainPage controller
    public void Nombre()
    {
        AlienNamePage.SetActive(true);
        Tekni.SetActive(true);
        Equus.SetActive(true);
        Scavenger.SetActive(true);
        Mekkari.SetActive(true);
    }

    public void Alimento()
    {
        AlimentPage.SetActive(true);
    }
    public void Tipo()
    {
        TypePage.SetActive(true);
    }
    public void Isla()
    {
        IslePage.SetActive(true);
    }

    public void ExitBuscador()
    {
        IslePage.SetActive(false);
        AlimentPage.SetActive(false);
        TypePage.SetActive(false);
        AlienNamePage.SetActive(false);

        foreach (var button in AlienNameButtons)
        {
            button.SetActive(false);
        }
    }

    // subpages controller
    public void AlienPageActived(int alienID)
    {
        CheckActualScene().SetActive(false);
        Scenes[alienID].SetActive(true);
    }

    public void ShowAlienMatchingFilter(int alienID)
    {
        AlienNamePage.SetActive(true);
        AlienNameButtons[alienID].SetActive(true);
    }

    public void InstanceScriptArray()
    {
        Scenes = new GameObject[4] { TekniScene, EquusScene, ScavengerScene, MekkariScene };
        AlienNameButtons = new GameObject[4] { Tekni, Equus, Scavenger, Mekkari };
        Scenes[0].SetActive(true);
    }

    // alien scene change
    public GameObject CheckActualScene()
    {

        foreach (GameObject scene in Scenes)
        {
            if (scene.activeInHierarchy == true)
            {
                ActualScene = scene;
            }
        }
        return ActualScene;
    }

    
    
}
