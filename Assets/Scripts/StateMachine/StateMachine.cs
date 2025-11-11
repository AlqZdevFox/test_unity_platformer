using UnityEngine;

public class StateMachine
{
    #region Class Variables
    public StateManager currentState { get; private set; } //I still love how easy it is to make getters and setters in C-Sharp

    #endregion

    #region Methods
    public void EnterState(StateManager stateManager)
    {
        //Simple method for establishing the current state of the StateMachine as we INITialize this Script
        this.currentState = stateManager; //set the current State
        this.currentState.Enter(); //Actually enter the current State
    }//EndOf method EnterState

    public void ChangeState(StateManager state)
    {
        //Method meant to Change the State of the StateMachine
        this.currentState.Exit(); //First exit the current State
        EnterState(state); //Immediately after exiting the previous State, Init/Enter the new State
    }//EndOf method ChangeState

    #endregion
}
