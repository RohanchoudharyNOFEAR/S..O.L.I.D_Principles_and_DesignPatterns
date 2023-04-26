using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLeft : Command
{
    private BikeControllerForCommand _bikeController;

    public TurnLeft(BikeControllerForCommand bikeController)
    {
        _bikeController = bikeController;
    }

    public override void Execute()
    {
        _bikeController.Turn(BikeControllerForCommand.Direction.Left);
    }
}
