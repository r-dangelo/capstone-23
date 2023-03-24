using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour
{
    [SerializeField] AudioClip soundToPlay;
    [SerializeField] AudioSource source;

    public void playFrequency()
    {
        source.clip = soundToPlay;
        source.Play();
    }
}