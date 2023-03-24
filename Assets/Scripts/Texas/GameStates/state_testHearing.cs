using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_testHearing : State
{
    private GameFSM stateMachine;
    private MainController controller;

    public state_testHearing(GameFSM _stateMachine, MainController _controller)
    {
        stateMachine = _stateMachine;
        controller = _controller;
    }

    public override void Enter()
    {
        Debug.Log("STATE: Hearing Test");
        controller.hearingTestPanel.SetActive(true);
    }

    public override void Exit()
    {
        // record info
        controller.hearingTestPanel.SetActive(false);
    }

    public override void Tick()
    {
        base.Tick();
    }
}
