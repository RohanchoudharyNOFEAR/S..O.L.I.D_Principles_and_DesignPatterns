using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedState : PlayerStatesBase
{
    protected Vector3 Input;

    protected override void OnEnter()
    {
        Debug.Log("Entered Into GroundedState");
          base.OnEnter();
    }
    protected override void OnUpdate()
    {
      
         base.OnUpdate();
        PSC.CameraController.CameraMove(PSC.playerInputs.InputMouseVector);
        Input = PSC.playerInputs.InputMovementVector;
       
      //  Debug.Log(Input);
        Debug.Log("update call Into GroundedState");
    }
    protected override void OnExit()
    {
        Debug.Log(" Exit From GroundedState");
        base.OnExit();
    }
}
