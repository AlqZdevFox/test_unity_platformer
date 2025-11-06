using System;
using System.Collections;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    #region Global Variables
    PlayerBaseState currentState; //We only want to be in one specific state at a time, so we set a variable for it

    //Each unique Player State gets its variable, instantiated from the respective Script yadda yadda
    //NOTE: These are exemplary states, we can flesh out or change/delete any state for experimentation's sake
    public PlayerDamagedState DamagedState = new PlayerDamagedState();
    public PlayerFallingState FallingState = new PlayerFallingState();
    public PlayerIdleState IdleState = new PlayerIdleState();
    public PlayerJumpingState JumpingState = new PlayerJumpingState();

    #endregion

    #region Unity Methods
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //By default, enter a concrete state, which in this case I think Idle makes the most sense, from there you can get to any other state
        currentState = IdleState;
        //The parameter of EnterState "this" refers to the context, THIS Script, the PlayerStateManager.cs Script
        currentState.EnterState(this);
    }//EndOf Unity method Start

    // Update is called once per frame
    void Update()
    {
        //Calls whatever state's UpdateState method every frame
        //No, UpdateState in each independent state does NOT update every frame, but THIS script's Update does, it's an Unity method!
        currentState.UpdateState(this);
    }//EndOf Unity method Update

    #endregion

    #region Own Methods
    public void SwitchState(PlayerBaseState playerState)
    {
        //This method means to give the ability to change states, from one to another
        //Up above you see we start with Idle State, but the player moves, interacts and does stuff
        //Can't have much of a game if the player JUST idles, right?
        currentState = playerState; //set current state as the one passed as a parameter, whichever it may be
        playerState.EnterState(this); //TODO: Get back to this in the video
    }//EndOf method SwitchState

    #endregion
}
