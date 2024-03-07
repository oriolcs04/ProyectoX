using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceController : MonoBehaviour
{
    public static AudioSourceController audioSourceControllerInstance;
    private void Awake()
    {
        if (AudioSourceController.audioSourceControllerInstance == null)
        {
            AudioSourceController.audioSourceControllerInstance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    
}
