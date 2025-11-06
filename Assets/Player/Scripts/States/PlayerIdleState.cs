using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    #region Inherited Methods
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Yeah I be just idling really, ENTERING the Idle State if you will, yeah.");
    }//EndOf overwritten method EnterState
    
    public override void UpdateState(PlayerStateManager player)
    {
        /*
        If PLAYER_INPUT, switch to State according to Action
        //NOTE: Come back to IdleState when Player is Grounded, not FALLING nor BEING ATTACKED nor MOVING/RUNNING
        */
        
        //TODO: Have a basic animation, or nothing at all, this is just a prototype after all
    }//EndOf overwritten method UpdateState

    #endregion
}
