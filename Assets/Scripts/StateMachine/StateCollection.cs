using Unity.VisualScripting;
using UnityEngine;

public class StateCollection
{
    #region Class Variables
    //These sub States are defined under any "Ground" state, the latter being a Super State (a mothership of states if you will)
    public StateSubIdle IDLESTATE { get; private set; }
    public StateSubIdle MOVESTATE { get; private set; }

    #endregion

    #region Constructor Methods
    //ALL States have a PlayerGeneral and StateMachine parameters in the Constructor param Box
    public StateCollection(PlayerGeneral playerGeneral, StateMachine stateMachine)
    {
        IDLESTATE = new StateSubIdle(playerGeneral, stateMachine);
        MOVESTATE = new StateSubIdle(playerGeneral, stateMachine);
    }//EndOf Constructor methodt StateCollection
    #endregion
}
