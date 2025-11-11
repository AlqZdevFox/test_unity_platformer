using UnityEngine;

public class StateSubMovement : StateSuperGround
{
    #region Constructor Methods
    // " : base(STUFF, STUFF)" gets the Constructor from the Class we're inheriting from
    public StateSubMovement(PlayerGeneral PLAYERGENERAL, StateMachine STATEMACHINE) : base(PLAYERGENERAL, STATEMACHINE)
    {

    }//EndOf Constructor method StateSubIdle
    
    #endregion
}
