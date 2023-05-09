using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_testHearing : State
{
    private GameFSM stateMachine;
    private MainController controller;
    private JournalTracker journal;

    public state_testHearing(GameFSM _stateMachine, MainController _controller, JournalTracker _journal)
    {
        stateMachine = _stateMachine;
        controller = _controller;
        journal = _journal;
    }

    public override void Enter()
    {
        Debug.Log("STATE: Hearing Test");
        controller.setPettable(false);
        controller.panels.hearingTestPanel.SetActive(true);
        controller.moveCreature(nameof(state_testHearing));
    }

    public override void Exit()
    {
        controller.setPettable(true);
        controller.panels.hearingTestPanel.SetActive(false);
        controller.resetCreature();
    }

    public override void Tick()
    {
        base.Tick();
    }
}
