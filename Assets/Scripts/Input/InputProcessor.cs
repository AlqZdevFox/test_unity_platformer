using UnityEngine;

public class InputProcessor
{
    //The tutorial makes an empty Constructor but that's so stupid, he literally made it SAYING it's pointless xd
    //Again, since it's redundant, I won't do it myself

    #region Class Variables
    private Vector2 inputVector;
    public Vector2 INPUTVECTOR => inputVector; //Getter for the inputVector as is, raw
    public Vector2 INPUTVECTORNORMALIZED => inputVector.normalized; //Getter for the inputVector normalized, with the diagonals better calculated, trimmed even you could say

    #endregion

    #region Own Methods
    public void ProcessInputVector(Vector2 value)
    {
        this.inputVector = value; //Get whatever vector we get, either from WASD or Stick, and set our inputVector to that, easy
    }//EndOf method ProcessInputVector

    #endregion
}
