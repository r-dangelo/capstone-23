using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(MainController))]
[RequireComponent(typeof(JournalTracker))]
public class GameFSM : StateMachineMB
{
    private MainController controller;
    private JournalTracker journal;
    private PlayUISounds sounds;
    
    // Members of the Union (States)
    public state_Setup setup { get; private set; }
    public state_Main main { get; private set; }
    public state_testHearing hearingTest { get; private set; }
    public state_testXRay xrayTest { get; private set; }
    public state_testMicroscope microscopeTest { get; private set; }

    private void Awake()
    {
        controller = GetComponent<MainController>();
        setup = new state_Setup(this, controller);
        main = new state_Main(this, controller);
        hearingTest = new state_testHearing(this, controller, journal);
        xrayTest = new state_testXRay(this, controller, journal);
        microscopeTest = new state_testMicroscope(this, controller, journal);
        sounds = controller.gameObject.GetComponent<PlayUISounds>();
    }

    private void Start()
    {
        base.ChangeState(setup);
    }

    public void ChangeToSetup() { 
        ChangeState(setup);
    }

    public void ChangeToMain() {
        ChangeState(main);
        sounds.playCancelSound();
        controller.gameObject.GetComponent<ChangeMusic>().toggleMusic();
    }

    public void ChangeToHearingTest() {
        ChangeState(hearingTest);
        sounds.playSelectSound();
        controller.gameObject.GetComponent<ChangeMusic>().duckMusic();
    }

    public void ChangeToXRayTest() {
        ChangeState(xrayTest);
        sounds.playSelectSound();
        controller.gameObject.GetComponent<ChangeMusic>().toggleMusic();
    }

    public void ChangeToMicroscope() {
        ChangeState(microscopeTest);
        sounds.playSelectSound();
        controller.gameObject.GetComponent<ChangeMusic>().toggleMusic();
    }
}
