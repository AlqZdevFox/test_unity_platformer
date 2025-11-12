using UnityEngine;

public class StateSubIdle : StateSuperGround
{
    #region Constructor Methods
    // " : base(STUFF, STUFF)" gets the Constructor from the Class we're inheriting from
    public StateSubIdle(PlayerGeneral PLAYERGENERAL, StateMachine STATEMACHINE) : base(PLAYERGENERAL, STATEMACHINE)
    {

    }//EndOf Constructor method StateSubMovement

    #endregion

    #region Overwritten Methods
    public override void Enter()
    {
        //When entering, do what all Sub States do
        base.Enter();

        //And THEN, set the Movement to the Idle Movement, whenever entering the Sub State IDLE
        PLAYER.MOVEMENT.VelocityIdle();
    }//EndOf overwritten method Enter

    public override void Update()
    {
        //Do what all Sub States do when they enter Update
        base.Update();

        //If there's an input of any kind in the WASD or Stick (anything greater than not having input, therefore input greater than 0)
        //For these checks, we don't need the trimmed down Input Vector, we just want to know if it IS being used or not.
        if(PLAYER.INPUTPROCESSOR.INPUTVECTOR.magnitude > 0)
        {
            //Change to the State of Movement, the MoveState
            STATEMACHINE.ChangeState(PLAYER.STATES.MOVESTATE);
        }//EndOf IF
    }//EndOf overwritten method Update

    #endregion
}
