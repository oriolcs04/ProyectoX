using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuscadorController : MonoBehaviour
{
    // Pag buscador
    public GameObject IslePage;
    public GameObject AlimentPage;
    public GameObject TypePage;
    public GameObject NamePage;

    // Alien Buttons 
    public GameObject Tekni;
    public GameObject Equus;
    public GameObject Scavenger;
    public GameObject Mekkari;

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
        NamePage.SetActive(true);
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
        NamePage.SetActive(false);

        Tekni.SetActive(false);
        Equus.SetActive(false);
        Scavenger.SetActive(false);
        Mekkari.SetActive(false);
    }

    // subpages controller
    public void Id1()
    {
        NamePage.SetActive(true);
        Tekni.SetActive(true);
    }
    public void Id2()
    {
        NamePage.SetActive(true);
        Equus.SetActive(true);
    }
    public void Id3()
    {
        NamePage.SetActive(true);
        Scavenger.SetActive(true);
    }
    public void Id4()
    {
        NamePage.SetActive(true);
        Mekkari.SetActive(true);
    }

    // alien scene change
    public GameObject CheckActualScene()
    {
        Scenes = new GameObject[4] { TekniScene, EquusScene, ScavengerScene, MekkariScene }; 

        foreach (GameObject scene in Scenes)
        {
            if (scene.activeInHierarchy == true)
            {
                ActualScene = scene;
            }
        }

        return ActualScene;
    }
    public void TekniSceneChange()
    {
        TekniScene.SetActive(true);
        ActualScene.SetActive(false);
    }
    public void EquusSceneChange()
    {
        EquusScene.SetActive(true);
        ActualScene.SetActive(false);
    }
    public void ScavengerSceneChange()
    {
        ScavengerScene.SetActive(true);
        ActualScene.SetActive(false);
    }
    public void MekkariSceneChange()
    {
        MekkariScene.SetActive(true);
        ActualScene.SetActive(false);
    }
}
