using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private GameObject audioSourceObject;

    public AudioSource audioSource;


    private void Awake()
    {
        audioSourceObject = GameObject.FindGameObjectWithTag("AudioSourceObject");
        audioSource = audioSourceObject.GetComponent<AudioSource>();
    }
    public void SetAudioState()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        else if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
