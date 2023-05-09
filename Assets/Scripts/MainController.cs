using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

[System.Serializable]
public class SampleTestController
{
    public Image controlImage;
    public Image topImage;
    public Image bottomImage;
}

public class MainController : MonoBehaviour
{
    List<CreatureController> creatures;
    public CreatureController currentCreature;
    [SerializeField] Texture2D cursor;
    [SerializeField] Texture2D petCursor;

    [Header("Panels")]
    public Panels panels;

    [Header("Creature Location for Panel")]
    public Locations location;

    [Header("Sample Test Image GameObjects")]
    public SampleTestController sampleTestLocations;

    int index = 0;
    IDictionary<string, RectTransform> locations = new Dictionary<string, RectTransform>();
    public int score = 0;

    private void Start()
    {
        creatures = new List<CreatureController>();
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
        
        GameObject[] creatureGO = GameObject.FindGameObjectsWithTag("Creature");
        foreach (GameObject obj in creatureGO)
        {
            if (obj.gameObject.GetComponent<CreatureController>() != null)
            {
                creatures.Add(obj.gameObject.GetComponent<CreatureController>());
            }
        }

        currentCreature = creatures[0];

        locations.Add(nameof(state_Main), location.mainLocation);
        locations.Add(nameof(state_testHearing), location.soundLocation);
        locations.Add(nameof(state_testXRay), location.xrayLocation);
        locations.Add(nameof(state_testMicroscope), location.microscopeLocation);
    }

    public CreatureController changeCreature()
    {
        // pretty sure this is the right math, but i dislike arrays
        if(index+1 < creatures.Count-1){
            currentCreature = creatures[index++];
        }
        else if(index+1 == creatures.Count-1){
            currentCreature = creatures[0];
        }
        return currentCreature;
    }

    public void soundTestCorrectCreature(int frequencyNum)
    {        
        currentCreature.doSoundTest(frequencyNum);
    }

    public void xrayTestCorrectCreature(int buttonNumber)
    {
        currentCreature.doXRayTest(buttonNumber);
    }

    public void sampleTestCorrectCreature(int buttonNumber)
    {
        currentCreature.doSampleTest(buttonNumber);
        Sprite[] nextSprites = new Sprite[3];
        // nextSprites = currentCreature.getNextImages();
        /*sampleTestLocations.controlImage.sprite = nextSprites[0];
        sampleTestLocations.topImage.sprite = nextSprites[1];
        sampleTestLocations.bottomImage.sprite = nextSprites[2];*/
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

    public void pettingCursor()
    {
        Cursor.SetCursor(petCursor, Vector2.zero, CursorMode.Auto);
    }

    public void resetCursor()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    public void setPettable(bool newPettability)
    {
        currentCreature.isPettable = newPettability;
    }

    public void quitGame()
    {
        Application.Quit();
    }
}