using UnityEngine;
using TMPro;

public class PlayerGeneral : MonoBehaviour
{
    #region Class Variables
    //We don't want the StateMachine in just any GameObject of the Scene, so we create them from our scripts
    private StateMachine StateMachine;
    public StateMachine STATEMACHINE => StateMachine; //So we're basically using the StateMachine class Getter

    //Instantiate StateCollection
    private StateCollection States;
    public StateCollection STATES => States; //And Getter them (they're private) <- Redundant, I didn't specify the protection modifiers before writing that comment xd

    //Instantiate the InputProcessor script/class
    private InputProcessor InputProcessor;
    public InputProcessor INPUTPROCESSOR => InputProcessor; //Getter it

    private PlayerMovement PlayerMovement;
    public PlayerMovement MOVEMENT => PlayerMovement;

    [Header("Components")] //Remember, Headers in Unity are used for organization purposes only, separating things into groups (visually)
    [SerializeField] Rigidbody Rigidbody;
    [SerializeField] PlayerConfiguration PlayerConfiguration;

    [Header("UI")]
    [SerializeField] TextMeshProUGUI CurrentState; //This meant to display the current State in-game, no need for Console Debug Logs

    #endregion

    #region Unity Methods
    private void Awake()
    {
        //Create the StateMachine using an empty Constructor
        StateMachine = new StateMachine();

        //Create a new State Collection for this script
        States = new StateCollection(this, StateMachine); //We can pass a "this" since StateCollection's Constructor asks for a PlayerGeneral, and guess where we are XD

        //Create a new Input Processor blablabla you know the drill
        InputProcessor = new InputProcessor();

        //Create new Player Movement
        PlayerMovement = new PlayerMovement(Rigidbody, PlayerConfiguration);
    }//EndOf Unity method Awake

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //For starters, default the initial state to the IdleState (EnterState method used to be Init, but I like it better named like this)
        StateMachine.EnterState(States.IDLESTATE);
    }//EndOf Unity method Start

    // Update is called once per frame
    //Of course, it's ideal for game logic that you want to check everytime during gameplay
    void Update()
    {
        // Execute the current State's Update method
        //Each State will have an inherited Update method from StateManager, since we made them virtual methods
        //Thus why we need to specifically call them to this Script, which DOES extend from MonoBehaviour
        //It is a bit messy to understand at first, but it's pretty self explainatory
        StateMachine.currentState.Update();

        //Set the Player's State Sign (TMPro) to whatever State they're in
        CurrentState.text = StateMachine.currentState.ToString();
    }//EndOf Unity method Update

    // FixedUpdate is called by the value of Time.fixedDeltaTime
    //Ideal for calculating physics, cuz of consistency (even tho there are ways to make Update calculate things consistently, but oh well)
    private void FixedUpdate()
    {
        StateMachine.currentState.FixedUpdate();
    }//EndOf Unity method FixedUpdate

    // LateUpdate is called once per frame, after every OTHER Update method have been called
    //Ideal for Cameras, for proper tracking of objects that may have moved inside the Update method
    private void LateUpdate()
    {
        StateMachine.currentState.LateUpdate();
    }//EndOf Unity method LateUpdate
    
    #endregion
}
