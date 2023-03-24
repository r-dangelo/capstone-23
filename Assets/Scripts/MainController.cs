using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class Panels
{
    [SerializeField] public GameObject mainPanel;
    [SerializeField] public GameObject hearingTestPanel;
    [SerializeField] public GameObject xrayTestPanel;
    [SerializeField] public GameObject sampleTestPanel;
}

[System.Serializable]
public class Locations
{
    [SerializeField] public RectTransform mainLocation;
    [SerializeField] public RectTransform soundLocation;
    [SerializeField] public RectTransform xrayLocation;
    [SerializeField] public RectTransform microscopeLocation;
}

public class MainController : MonoBehaviour
{
    [SerializeField] CreatureController[] creatures;
    [SerializeField] CreatureController currentCreature;

    [Header("Panels")]
    public Panels panels;

    [Header("Creature Location for Panel")]
    public Locations location;

    [Header("Sounds")]

    int index = 0;
    IDictionary<string, RectTransform> locations = new Dictionary<string, RectTransform>();

    private void Start()
    {
        currentCreature = creatures[0];

        locations.Add("state_Main", location.mainLocation);
        locations.Add("state_testHearing", location.soundLocation);
        locations.Add("state_testXRay", location.xrayLocation);
        locations.Add("state_testMicroscope", location.microscopeLocation);
    }

    public CreatureController changeCreature()
    {
        // pretty sure this is the right math, but i dislike arrays
        if(index+1 < creatures.Length-1){
            currentCreature = creatures[index++];
        }
        else if(index+1 == creatures.Length-1){
            currentCreature = creatures[0];
        }
        return currentCreature;
    }

    public void soundTestCorrectCreature(int frequencyNum)
    {        
        currentCreature.doSoundTest(frequencyNum);
    }

    public void xrayTestCorrectCreature()
    {
        currentCreature.doXRayTest();
    }

    public void sampleTestCorrectCreature()
    {
        currentCreature.doSampleTest();
    }

    public void moveCreature(string StateNameMessy)
    {
        RectTransform newLocation = locations[StateNameMessy];
        currentCreature.moveCreature(newLocation.localPosition);
    }

    public void resetCreature()
    {
        currentCreature.resetCreature();
    }
}