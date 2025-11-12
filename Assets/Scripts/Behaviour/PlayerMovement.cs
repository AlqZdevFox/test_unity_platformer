using UnityEngine;

public class PlayerMovement
{
    //This script is NOT a MonoBehaviour, since we want to use its scripts somewhere else

    #region Class Variables
    Rigidbody Rigidbody;
    PlayerConfiguration PlayerConfiguration;

    #endregion

    #region Constructor Methods
    public PlayerMovement(Rigidbody rigidbody, PlayerConfiguration playerConfiguration)
    {
        //When we want to use this PlayerMovement script, we need to have a RigidBody and look up at the Player Configuration
        //Thus, we have the Constructor need said things (Rigidbody for movement, Player Configuration to look at some tweaked settings I'd guess)
        this.Rigidbody = rigidbody;
        this.PlayerConfiguration = playerConfiguration;
    }//EndOf Constructor method PlayerMovement

    #endregion

    #region Own Methods
    public void VelocityMovement(Vector2 inputVec)
    {
        //Yes, the Z axis reads a Y value, but we're parsing a 2D vector onto a 3D vector, it'll make sense I promise
        Vector3 movement = new Vector3(inputVec.x, 0f, inputVec.y) * PlayerConfiguration.MOVESPEED;

        //Set this new Vector3 onto the script's Rigidbody
        //No, we can't make the calculation in the assignation itself, I tried in other prototypes, it just won't go your way, trust me.
        Rigidbody.linearVelocity = movement;
    }//EndOf method VelocityMovement

    public void VelocityIdle()
    {
        Rigidbody.linearVelocity = Vector3.zero; //Why would you want to move while idling, you dummy. This stops the Player on their tracks when Idle
    }//EndOf method VelocityIdle

    #endregion
}
