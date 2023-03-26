using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityState : PlayerStatesBase
{
    protected bool IsAbilityDone;

    protected override void OnEnter()
    {
        base.OnEnter();
        IsAbilityDone = false;
    }

    protected override void OnExit()
    {
        base.OnExit();
    }

    protected override void OnUpdate()
    {
     
        base.OnUpdate();
        if(IsAbilityDone)
        {
            if(PSC.PlayerMovement.Cc.isGrounded)
            {
                PSC.ChangeState(PSC.IdleState);
            }
            else
            {
                PSC.ChangeState(PSC.InAirState);
            }
        }
    }
}
