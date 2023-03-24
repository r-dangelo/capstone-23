using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_testXRay : State
{
    private GameFSM stateMachine;
    private MainController controller;

    public state_testXRay(GameFSM _stateMachine, MainController _controller)
    {
        stateMachine = _stateMachine;
        controller = _controller;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("STATE: XRay Test");
        controller.panels.xrayTestPanel.SetActive(true);
        controller.moveCreature("state_testXRay");
    }

    public override void Exit()
    {
        controller.panels.xrayTestPanel.SetActive(false);
    }

    public override void Tick()
    {
        base.Tick();
    }
}
