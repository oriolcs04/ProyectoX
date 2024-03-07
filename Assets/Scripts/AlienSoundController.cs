using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AlienSoundController : MonoBehaviour
{
    // Alien scenes prefabs
    public GameObject tekniScene;
    public GameObject equusScene;
    public GameObject scavengerScene;
    public GameObject mekkariScene;
    public GameObject actualScene;
    public GameObject[] scenes;

    public AudioSource audioSource;

    public bool soundCooldown = true;

    
    public void PlayAlienSound()
    {
        audioSource = CheckActualScene().GetComponent<AudioSource>();
        if (soundCooldown && !audioSource.isPlaying)
        {
            StartCoroutine(SoundCooldown());
        }
    }

    private void Start()
    {
        InstanceScriptArray();
    }

    public void InstanceScriptArray()
    {
        scenes = new GameObject[4] { tekniScene, equusScene, scavengerScene, mekkariScene };
    }

    IEnumerator SoundCooldown()
    {
        soundCooldown = false;
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        soundCooldown = true;
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
}
