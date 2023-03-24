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
        Debug.Log("STATE: Main");
        controller.panels.mainPanel.SetActive(true);
        controller.moveCreature("state_Main");
    }

    public override void Exit()
    {
        controller.panels.mainPanel.SetActive(false);
        base.Exit();
    }

    public override void Tick()
    {
        base.Tick();
    }
}
