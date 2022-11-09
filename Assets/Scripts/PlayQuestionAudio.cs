using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayQuestionAudio : MonoBehaviour
{ 
    AudioSource _audioSource;

    public void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    
    public void PlaySound()
    {
        _audioSource.Play();
    }
}
