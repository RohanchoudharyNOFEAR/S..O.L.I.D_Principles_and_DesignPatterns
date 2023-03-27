using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateController : MonoBehaviour//we are inheriting from player to access or communicate with other scripts that will be needed to states . we can do the same in here also but it will de isorganized
{
    [Header("Player Fields")]
    public PlayerInputs playerInputs;
    public PlayerMovement PlayerMovement;
    public PlayerAnimations PlayerAnimations;
    public CameraMovement CameraController;
    public PlayerChecks PlayerChecks;
    public CharacterController cc;
    public PlayerJump PlayerJump;

    public PlayerStatesBase currentState { get; private set; }

    public GroundedState GroundedState = new GroundedState();
    public AbilityState AbilityState = new AbilityState();
    public IdleState IdleState = new IdleState();
    public MoveState MoveState = new MoveState();
    public JumpState JumpState = new JumpState();
    public LandState LandState = new LandState();
    public InAirState InAirState = new InAirState();

    // Start is called before the first frame update
    private void Start()
    {
        cc = GetComponent<CharacterController>();
        PlayerChecks = GetComponent<PlayerChecks>();
       
        PlayerMovement = GetComponent<PlayerMovement>();
        PlayerJump = GetComponent<PlayerJump>();
        playerInputs = GetComponent<PlayerInputs>();
        PlayerAnimations = GetComponent<PlayerAnimations>();
        
        ChangeState(IdleState);
    }

    // Update is called once per frame
    private void Update()
    {
      
        if (currentState != null)
        {
            currentState.OnStateUpdate();
        }
    }

    public void ChangeState(PlayerStatesBase newState)
    {
        if (currentState != null)
        {
            currentState.OnStateExit();
        }

        currentState = newState;
        currentState.OnStateEnter(this);

    }

    

}
