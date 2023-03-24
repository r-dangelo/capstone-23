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
        base.Enter();
        Debug.Log("STATE: Microscope Test");
        controller.sampleTestPanel.SetActive(true);
    }

    public override void Exit()
    {
        base.Exit();
        controller.sampleTestPanel.SetActive(false);
    }

    public override void Tick()
    {
        base.Tick();
    }
}
