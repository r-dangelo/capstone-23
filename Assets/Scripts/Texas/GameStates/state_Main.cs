using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_Main : State
{
    private GameFSM stateMachine;
    private MainController controller;

    public state_Main(GameFSM _stateMachine, MainController _controller)
    {
        stateMachine = _stateMachine;
        controller = _controller;
    }

    public override void Enter()
    {
        base.Enter();
        controller.mainPanel.SetActive(true);
        Debug.Log("STATE: Main");
    }

    public override void Exit()
    {
        controller.mainPanel.SetActive(false);
        base.Exit();
    }

    public override void Tick()
    {
        base.Tick();
    }
}
