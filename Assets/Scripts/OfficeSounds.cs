﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeSounds : MonoBehaviour
{
    AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            source.Play();
        }
        else
        {
            source.Pause();
        }
    }
}
