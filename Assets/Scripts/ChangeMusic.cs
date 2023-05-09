using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMusic : MonoBehaviour
{
    [SerializeField] AudioSource focusMusic;
    [SerializeField] AudioSource fullMusic;

    bool isFullPlaying = false;

    public void toggleMusic()
    {
        if(isFullPlaying) {
            fullMusic.volume = 0;
            focusMusic.volume = 1 ;
            isFullPlaying = false;
        }
        else {
            fullMusic.volume = 1;
            focusMusic.volume = 0;
            isFullPlaying = true;
        }
    }
}
