using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    #region Class Variables
    [SerializeField] PlayerGeneral PLAYER;

    #endregion

    #region Own Methods
    public void InputMovement(InputAction.CallbackContext context)
    {
        //Call the PlayerGeneral's Input Processor we made
        //ProcessInputVector needed to be passed a Vector2, so read the context's Vector2 value and do so
        PLAYER.INPUTPROCESSOR.ProcessInputVector(context.ReadValue<Vector2>());

        //TODO: There will be more Input Processing, but for now we only have the simple Movement done
    }//EndOf method InputMovement

    #endregion
}
