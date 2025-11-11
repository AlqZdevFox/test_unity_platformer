using UnityEngine;

public class StateSubIdle : StateSuperGround
{
    #region Constructor Methods
    // " : base(STUFF, STUFF)" gets the Constructor from the Class we're inheriting from
    public StateSubIdle(PlayerGeneral PLAYERGENERAL, StateMachine STATEMACHINE) : base(PLAYERGENERAL, STATEMACHINE)
    {

    }//EndOf Constructor method StateSubMovement
    
    #endregion
}
