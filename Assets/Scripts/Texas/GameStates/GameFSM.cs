using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum States
{
    Setup, Main, HearingTest, XRayTest, MicroscopeTest
};

[RequireComponent(typeof(MainController))]
public class GameFSM : StateMachineMB
{
    private MainController controller;
    
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
        hearingTest = new state_testHearing(this, controller);
        xrayTest = new state_testXRay(this, controller);
        microscopeTest = new state_testMicroscope(this, controller);
    }

    private void Start()
    {
        base.ChangeState(setup);
    }

    public new void ChangeState(State newState)
    {
        base.ChangeState(newState);
    }
}
