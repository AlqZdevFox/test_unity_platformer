using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    #region Inherited Methods
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Yeah I be just idling really, ENTERING the Idle State if you will, yeah.");
    }
    
    public override void UpdateState(PlayerStateManager player)
    {
        
    }

    #endregion
}
