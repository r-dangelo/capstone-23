using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class state_testMicroscope : State
{
    private GameFSM stateMachine;
    private MainController controller;
    private JournalTracker journal;

    public state_testMicroscope(GameFSM _stateMachine, MainController _controller, JournalTracker _journal)
    {
        stateMachine = _stateMachine;
        controller = _controller;
        journal = _journal;
    }

    public override void Enter()
    {
        Debug.Log("STATE: Microscope Test");
        controller.setPettable(false);
        controller.panels.sampleTestPanel.SetActive(true);
        controller.moveCreature("state_testMicroscope");
    }

    public override void Exit()
    {
        // record info
        controller.setPettable(true);
        controller.panels.sampleTestPanel.SetActive(false);
        controller.resetCreature();
    }

    public override void Tick()
    {
        base.Tick();
    }
}
