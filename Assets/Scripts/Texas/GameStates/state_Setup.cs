using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_Setup : State
{
    private GameFSM stateMachine;
    private MainController controller;

    public state_Setup(GameFSM _stateMachine, MainController _controller)
    {
        stateMachine= _stateMachine;
        controller= _controller;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("STATE: Setup");
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Tick()
    {
        base.Tick();
        stateMachine.ChangeState(stateMachine.main);
    }
}
