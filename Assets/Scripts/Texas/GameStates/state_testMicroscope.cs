using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_testMicroscope : State
{
    private GameFSM stateMachine;
    private MainController controller;

    public state_testMicroscope(GameFSM _stateMachine, MainController _controller)
    {
        stateMachine = _stateMachine;
        controller = _controller;
    }

    public override void Enter()
    {
        Debug.Log("STATE: Microscope Test");
        controller.panels.sampleTestPanel.SetActive(true);
        controller.moveCreature("state_testMicroscope");
    }

    public override void Exit()
    {
        // record info
        controller.panels.sampleTestPanel.SetActive(false);
    }

    public override void Tick()
    {
        base.Tick();
    }
}
