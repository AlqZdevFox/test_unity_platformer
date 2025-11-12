using UnityEngine;

public class StateSubMovement : StateSuperGround
{
    #region Constructor Methods
    // " : base(STUFF, STUFF)" gets the Constructor from the Class we're inheriting from
    public StateSubMovement(PlayerGeneral PLAYERGENERAL, StateMachine STATEMACHINE) : base(PLAYERGENERAL, STATEMACHINE)
    {

    }//EndOf Constructor method StateSubIdle

    #endregion

    #region Overwritten Methods
    public override void Update()
    {
        //Do what all Sub States do when they enter Update
        base.Update();

        //If the input given by the Player when moving (WASD/Stick) is non-existent, therefore 0 (or less, computer numbers can be whacky and often non exact)
        //For these checks, we don't need the trimmed down Input Vector, we just want to know if it IS being used or not.
        if (PLAYER.INPUTPROCESSOR.INPUTVECTOR.magnitude == 0)
        {
            //Change to the Sub State Idle, the IdleState
            STATEMACHINE.ChangeState(PLAYER.STATES.IDLESTATE);
        }//EndOf IF
    }//EndOf overwritten method Update

    public override void FixedUpdate()
    {
        //Overwriting shenanigans, do whatever the Father script does
        base.FixedUpdate();

        //Call the VelocityMovement method in the PlayerMovement script
        PLAYER.MOVEMENT.VelocityMovement(PLAYER.INPUTPROCESSOR.INPUTVECTORNORMALIZED); //Pass the normalized vector, we now want to be exact and not have diagonals be faster
    }//EndOf overwritten method FixedUpdate

    #endregion
}
