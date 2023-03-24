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
        controller.panels.hearingTestPanel.SetActive(true);
        controller.moveCreature("state_testHearing");
    }

    public override void Exit()
    {
        // record info
        controller.panels.hearingTestPanel.SetActive(false);
        controller.resetCreature();
    }

    public override void Tick()
    {
        base.Tick();
    }
}
