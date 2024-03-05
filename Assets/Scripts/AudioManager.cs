using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private bool musicMuted;

    public static AudioManager muteMusic;

    public AudioSource audioSource;


    private void Awake()
    {
        if (AudioManager.muteMusic == null)
        {
            AudioManager.muteMusic = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
        musicMuted = false;
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += ControlMusicStatus;
    }

    private void ControlMusicStatus(Scene arg0, LoadSceneMode arg1)
    {
        audioSource = GetComponent<AudioSource>();

        if (musicMuted == true)
        {            
            audioSource.Play();
        }
        else if (musicMuted == false)
        {
            audioSource.Stop();
        }
    }

    public void SetMusicStatus()
    {
        musicMuted = !musicMuted;
    }
}
