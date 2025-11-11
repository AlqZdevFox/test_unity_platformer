using UnityEngine;

public class StateManager
{
    #region Class Variables
    protected StateMachine STATEMACHINE;
    protected PlayerGeneral PLAYER;

    #endregion

    #region Constructor Methods
    public StateManager(PlayerGeneral PLAYERGENERAL, StateMachine STATEMACHINE)
    {
        this.PLAYER = PLAYERGENERAL;
        this.STATEMACHINE = STATEMACHINE;
    }//EndOf StateManager Constructor

    #endregion

    #region Own Methods
    /*
    Note to AlqZ: "virtual" methods are meant to the overwritten by any class (script) that inherits from this Script/Class
    */

    public virtual void Enter()
    {
        //This method is used to ENTER a State in the State Machine (duh)
    }//EndOf virtual method Enter

    public virtual void Exit()
    {
        //This method is used to EXIT a State in the State Machine (duh)
    }//EndOf virtual method Exit

    public virtual void Update()
    {
        //
    }//EndOf virtual method Update

    public virtual void FixedUpdate()
    {
        //
    }//EndOf virtual method FixedUpdate

    public virtual void LateUpdate()
    {
        //
    }//EndOf virtual method LateUpdate

    #endregion
}
