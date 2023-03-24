using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    [SerializeField] CreatureController[] creatures;
    [SerializeField] CreatureController currentCreature;

    [Header("Panels")]
    [SerializeField] public GameObject mainPanel;
    [SerializeField] public GameObject hearingTestPanel;
    [SerializeField] public GameObject xrayTestPanel;
    [SerializeField] public GameObject sampleTestPanel;

    int index = 0;

    private void Start()
    {
        currentCreature = creatures[0];
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

    public void soundTestCorrectCreature()
    {
        currentCreature.doSoundTest();
    }

    public void xrayTestCorrectCreature()
    {
        currentCreature.doXRayTest();
    }

    public void sampleTestCorrectCreature()
    {
        currentCreature.doSampleTest();
    }
}