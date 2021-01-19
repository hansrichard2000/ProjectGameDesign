﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //public static SoundManager instance;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
       //instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
        audioSource.Play();
    }
    public void StopSound()
    {
        audioSource.Stop();
    }
}
