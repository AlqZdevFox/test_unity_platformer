using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    #region Global Variables
    PlayerBaseState currentState; //We only want to be in one specific state at a time, so we set a variable for it

    //Each unique Player State gets its variable, instantiated from the respective Script yadda yadda
    //NOTE: These are exemplary states, we can flesh out or change/delete any state for experimentation's sake
    PlayerDamagedState DamagedState = new PlayerDamagedState();
    PlayerFallingState FallingState = new PlayerFallingState();
    PlayerIdleState IdleState = new PlayerIdleState();
    PlayerJumpingState JumpingState = new PlayerJumpingState();

    #endregion

    #region Unity Methods
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //By default, enter a concrete state, which in this case I think Idle makes the most sense, from there you can get to any other state
        currentState = IdleState;
        currentState.EnterState(this);
    }//EndOf Unity method Start

    // Update is called once per frame
    void Update()
    {

    }//EndOf Unity method Update
    
    #endregion
}
