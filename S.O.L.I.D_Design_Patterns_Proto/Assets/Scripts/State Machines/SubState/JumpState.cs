using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : AbilityState
{

   

    protected override void OnEnter()
    {
        base.OnEnter();
        Debug.Log("entered jump state");

        PSC.PlayerJump.enabled = true;
        PSC.PlayerAnimations.SetJumpBool(true);
        PSC.PlayerJump.verticalVelocity = PSC.PlayerJump.JumpForce;
       
        IsAbilityDone = true;

    }

    protected override void OnExit()
    {
        base.OnExit();
       
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();
        
    }

   

}
