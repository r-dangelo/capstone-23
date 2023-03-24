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
        controller.xrayTestPanel.SetActive(true);
    }

    public override void Exit()
    {
        base.Exit();
        controller.xrayTestPanel.SetActive(true);
    }

    public override void Tick()
    {
        base.Tick();
    }
}
