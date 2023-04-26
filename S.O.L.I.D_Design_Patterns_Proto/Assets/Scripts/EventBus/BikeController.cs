using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    private string _status;

    private void OnEnable()
    {
        EventBus.Subscribe(RaceEventType.Start, startBike);
        EventBus.Subscribe(RaceEventType.Stop, stopBike);

    }
    private void OnDisable()
    {
        EventBus.Unsubscribe(RaceEventType.Start, startBike);
        EventBus.Unsubscribe(RaceEventType.Stop, stopBike);
    }
    private void startBike()
    {
        _status = "bikestarts";
    }
    private void stopBike()
    {
        _status = "bikeStops";
    }

    private void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(10, 60, 200, 20), "BIKE STATUS " + _status);
    }
}
