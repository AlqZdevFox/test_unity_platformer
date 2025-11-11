using UnityEngine;

public class StateSuperGround : StateManager
{
    #region Constructor Methods
    // " : base(STUFF, STUFF)" gets the Constructor from the Class we're inheriting from
    public StateSuperGround(PlayerGeneral PLAYER, StateMachine STATEMACHINE) : base(PLAYER, STATEMACHINE)
    {

    }//EndOf Constructor method StateSuperGround
    
    #endregion

    #region Overwritten Methods
    //Empty for now

    #endregion
}
