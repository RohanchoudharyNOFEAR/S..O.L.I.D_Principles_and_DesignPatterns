using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRight : Command
{
    private BikeControllerForCommand _bikeController;

    public TurnRight(BikeControllerForCommand bikeController)
    {
        _bikeController = bikeController;
    }

    public override void Execute()
    {
        _bikeController.Turn(BikeControllerForCommand.Direction.Right);
    }
}
