using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_testXRay : State
{
    private GameFSM stateMachine;
    private MainController controller;
    private JournalTracker journal;

    public state_testXRay(GameFSM _stateMachine, MainController _controller, JournalTracker _journal)
    {
        stateMachine = _stateMachine;
        controller = _controller;
        journal = _journal;
    }

    public override void Enter()
    {
        Debug.Log("STATE: XRay Test");
        controller.setPettable(false);
        controller.panels.xrayTestPanel.SetActive(true);
        controller.moveCreature("state_testXRay");
    }

    public override void Exit()
    {
        // record info
        controller.setPettable(true);
        controller.panels.xrayTestPanel.SetActive(false);
        controller.resetCreature();
    }

    public override void Tick()
    {
        base.Tick();
    }
}
