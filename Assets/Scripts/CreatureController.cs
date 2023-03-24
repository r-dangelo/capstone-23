using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public enum soundReactions
{
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

    [Header("Sprites")]
    public Sprite positiveReaction;
    public Sprite negativeReaction;
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
    [SerializeField] Animation petAnimation;

    Sprite defaultImage;

    private void Start()
    {
        defaultImage = gameObject.GetComponent<Image>().sprite;
    }

    public void doSoundTest(int frequencyNum)
    {
        soundReactions reaction = soundReactions.None;
        switch (frequencyNum) {
            case 1:
                reaction = soundTest.frequency1Reaction;
                break;
            case 2:
                reaction = soundTest.frequency2Reaction;
                break;
            case 3:
                reaction = soundTest.frequency3Reaction;
                break;
        }

        switch (reaction) {
            case soundReactions.None:
                gameObject.GetComponent<Image>().sprite = defaultImage;
                break;
            case soundReactions.Positive:
                gameObject.GetComponent<Image>().sprite = soundTest.positiveReaction;
                break;
            case soundReactions.Negative:
                gameObject.GetComponent<Image>().sprite = soundTest.negativeReaction;
                break;
        }
    }

    public void doXRayTest()
    {

    }

    public void doSampleTest()
    {

    }

    public void pet()
    {
        Debug.Log("pet");
        // petAnimation.Play();
    }

    public void moveCreature(Vector3 pos)
    {
        gameObject.GetComponent<RectTransform>().localPosition = pos;
    }

    public void resetCreature()
    {
        gameObject.GetComponent<Image>().sprite = defaultImage;
    }
}