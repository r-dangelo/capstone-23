using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_sound : MonoBehaviour
{
    [SerializeField] AudioClip[] soundTestFrequencies;
    AudioSource source;
    int currentSound = 0;

    private void Start()
    {
        source = gameObject.GetComponentInParent<AudioSource>();
    }

    void playNextSound()
    {
        currentSound = (currentSound + 1) % soundTestFrequencies.Length;

        AudioClip newClip = soundTestFrequencies[currentSound];
        source.clip = newClip;
        source.Play();
    }
}