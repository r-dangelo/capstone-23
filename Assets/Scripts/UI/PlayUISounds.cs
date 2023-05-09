using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Member;

[System.Serializable]
public class Sounds
{
    public AudioClip buttonClick;
    public AudioClip softSelect;
    public AudioClip cancelClick;
    public AudioClip panelSlide;
    public AudioClip hover;
}

public class PlayUISounds : MonoBehaviour
{
    [Header("Sounds")]
    public Sounds sound;
    AudioSource source;

    private void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    public void playSelectSound()
    {
        source.clip = sound.buttonClick;
        source.Play();
    }

    public void playCancelSound()
    {
        source.clip = sound.cancelClick;
        source.Play();
    }

    public void playHoverSound()
    {
        source.clip = sound.hover;
        source.Play();
    }

    public void playSoftSelect()
    {
        source.clip = sound.softSelect;
        source.Play();
    }

    public void playPanelSlideSound()
    {
        source.clip = sound.panelSlide;
        source.Play();
    }
}
