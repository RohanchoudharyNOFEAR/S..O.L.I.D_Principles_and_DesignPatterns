using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTurbo : Command
{
    private BikeControllerForCommand _bikeController;

    public ToggleTurbo(BikeControllerForCommand bikeController)
    {
        _bikeController = bikeController;
    }

    public override void Execute()
    {
        _bikeController.ToggleTurbo();
    }

}
