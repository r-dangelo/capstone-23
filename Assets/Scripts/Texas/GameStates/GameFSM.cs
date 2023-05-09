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
        controller.playCancelSound();
    }

    public void ChangeToHearingTest() {
        ChangeState(hearingTest);
        controller.playSelectSound();
    }

    public void ChangeToXRayTest() {
        ChangeState(xrayTest);
        controller.playSelectSound();
    }

    public void ChangeToMicroscope() {
        ChangeState(microscopeTest);
        controller.playSelectSound();
    }

}
