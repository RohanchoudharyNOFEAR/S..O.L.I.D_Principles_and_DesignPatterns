using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : GroundedState
{
  

    protected override void OnEnter()
    {
        PSC.PlayerMovement.enabled = true;
        Debug.Log("Entered Into MoveState");
          base.OnEnter();
    }
    protected override void OnUpdate()
    {
        PSC.PlayerMovement.Move(Input);
        PSC.PlayerAnimations.SetAnimMovementSpeed(Mathf.Clamp01(Input.magnitude));
        Debug.Log(Mathf.Clamp01(Input.magnitude));
        if (Input.x == 0 && Input.z == 0)
        {
            PSC.ChangeState(PSC.IdleState);
        }

        Debug.Log("update call Into MoveState");
         base.OnUpdate();
    }
    protected override void OnExit()
    {
        Debug.Log(" Exit From MoveState");
        base.OnExit();
    }
}
