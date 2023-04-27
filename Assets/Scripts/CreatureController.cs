using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Net;
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
    Decapoda, New, Carnivora
}

[System.Serializable]
public class Taxa
{
    public kingdoms kingdom;
    public phylums phylum;
    public classes classs;
    public orders order;
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
public struct XRayInfo
{
    [Range(1, 12)]
    public int importantSection;
    public string infoGained;
}

[System.Serializable]
public class XRayTest
{
    [Tooltip("Check this if the creature is invertebrate")]
    public bool hasExoskeleton;
    public XRayInfo[] ImportantSections;
}

[System.Serializable]
public class SampleTest
{
    public string moreCorrectInformation;
    public string correctInformation;
    public string unhelpfulInformation;
}

[System.Serializable]
public struct SampleTestImages
{
    public Sprite controlImage;
    public Sprite topImage;
    public Sprite bottomImage;
    public bool isTopImageCorrect;
}

public class CreatureController : MonoBehaviour
{
    [Header("Taxonomy")]
    [Tooltip("Please be careful when choosing.")]
    public Taxa taxa;

    [Header("Tests")]
    public SoundTest soundTest;
    public XRayTest xRayTest;
    public SampleTestImages[] sampleTest;

    [Header("Miscellaneous")]
    [SerializeField] AudioClip petSound;
    [SerializeField] MainController controller;

    Sprite defaultImage;
    int sampleTestIndex = 0;
    int sampleTestPoints = 0;

    public bool isPettable { get; set; }

    private void Start()
    {
        defaultImage = gameObject.GetComponent<Image>().sprite;
        isPettable = true;
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

    public void doXRayTest(int buttonNumber)
    {

    }

    public void doSampleTest(int buttonNumber)
    {
        try {
            SampleTestImages tester = sampleTest[sampleTestIndex];
            if (buttonNumber == 1 && tester.isTopImageCorrect) {
                sampleTestPoints++;
            }
            if (sampleTestIndex == 2) { endTest(); return; }
        }
        catch (IndexOutOfRangeException e) {
            Debug.Log(e + " Test Over, do something");
        }
        
    }

    void endTest()
    {
        switch (sampleTestPoints)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }

    }

    public Sprite[] getNextImages()
    {
        if (sampleTestIndex < sampleTest.Length) {
            Sprite[] nextImages = new Sprite[3];
            nextImages[0] = sampleTest[sampleTestIndex].controlImage;
            nextImages[1] = sampleTest[sampleTestIndex].topImage;
            nextImages[2] = sampleTest[sampleTestIndex].bottomImage;
            sampleTestIndex++;
            return nextImages;
        }
        return null;
    }

    public void pet()
    {
        if (isPettable)
        {
            AudioSource source = controller.GetComponent<AudioSource>();
            source.clip = petSound;
            source.Play();
        }
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