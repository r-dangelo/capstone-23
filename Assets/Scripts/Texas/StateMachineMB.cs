using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineMB : MonoBehaviour
{
    public State CurrState { get; private set; }
    private State PrevState;

    private bool transitioning = false;

    public void ChangeState(State newState)
    {
        if(CurrState == newState || transitioning) { return; }

        MoveStates(newState);
    }

    private void MoveStates(State newState)
    {
        transitioning = true;
        CurrState?.Exit();
        StorePreviousState(CurrState, newState);

        CurrState = newState;

        CurrState.Enter();
        transitioning = false;
    }

    private void StorePreviousState(State currentState, State newState)
    {
        if (newState == null && newState != null) {
            PrevState = newState;
        }

        else if (newState != null && CurrState != null) {
            PrevState = CurrState;
        }
    }

    public void ChangeToPrevious()
    {
        if (PrevState != null) {
            ChangeState(PrevState);
        }
    }

    protected virtual void Update()
    {
        if (CurrState != null && !transitioning) {
            CurrState.Tick();
        }
    }
}
