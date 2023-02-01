using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public enum soundReactions{
    None, Positive, Negative
}
public enum kingdoms{
    Animalia, Fungi
}
public enum phylums{
    Chordata, Arthropoda, New
}
public enum classes{
    Reptilia, Mammalia, Arachnida, Malacostraca, New
}
public enum orders{
    Decapoda, New
}

[System.Serializable]
public class Taxa
{
    [SerializeField] kingdoms kingdom;
    [SerializeField] phylums phylum;
    [SerializeField] classes classs;
    [SerializeField] orders order;
}

[System.Serializable]
public class SoundTest
{
    [Header("Frequency Reactions")]
    public soundReactions frequency1Reaction;
    public soundReactions frequency2Reaction;
    public soundReactions frequency3Reaction;

    [Header("Animations")]
    public AnimationClip positiveReaction;
    public AnimationClip negativeReaction;
}

[System.Serializable]
public class XRayTest
{
    [Tooltip("Check this if the creature is invertebrate")]
    [SerializeField] bool hasExoskeleton;
    [Range(1,20)]
    [SerializeField] int importantSection;
}

[System.Serializable]
// find some way of associating images with a value for comparison
public class SampleTest
{
    [SerializeField] Image controlImage;
    [SerializeField] Image[] comparisonImages;
}

public class CreatureController : MonoBehaviour
{
    [Header("Taxonomy")]
    [Tooltip("Please be careful when choosing.")]
    public Taxa taxa;

    [Header("Tests")]
    public SoundTest soundTest;
    public XRayTest xRayTest;
    public SampleTest sampleTest;

    [Header("Miscellaneous")]
    [SerializeField] AnimationClip petAnimation;

    int soundTestCount = 0;

    public void doSoundTest()
    {
        soundTestCount++;
        soundReactions frequencyReaction = soundReactions.None;
        if(soundTestCount == 1) { frequencyReaction = soundTest.frequency1Reaction; }
        else if(soundTestCount == 2) { frequencyReaction = soundTest.frequency2Reaction; }
        else if(soundTestCount == 3) { frequencyReaction= soundTest.frequency3Reaction; }

        switch (frequencyReaction) {
            case soundReactions.None:
                Debug.Log("None");
                break;
            case soundReactions.Positive:
                Debug.Log("positive");
                // soundTest.positiveReaction.GetComponent<Animation>().Play();
                break;
            case soundReactions.Negative:
                Debug.Log("negative");
                // soundTest.negativeReaction.GetComponent<Animation>().Play();
                break;
        }
        Debug.Log(soundTestCount);

        if (soundTestCount == 3) {
            soundTestCount = 0;
        }
    }

    public void doXRayTest()
    {

    }

    public void doSampleTest()
    {

    }

    public void doMRITest()
    {

    }
}