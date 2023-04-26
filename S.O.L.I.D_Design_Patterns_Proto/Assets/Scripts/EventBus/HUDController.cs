using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    private bool _isDisplayOn;

    private void OnEnable()
    {
        EventBus.Subscribe(RaceEventType.Start, DisplayHUD);
    }
    private void OnDisable()
    {
        EventBus.Unsubscribe(RaceEventType.Start, DisplayHUD);
    }

    void DisplayHUD()
    {
        _isDisplayOn = true;
    }

    private void OnGUI()
    {
        if(_isDisplayOn)
        {
            if(GUILayout.Button("STOP RACE"))
            {
                _isDisplayOn = false;
                EventBus.Publish(RaceEventType.Stop);
            }
        }
    }

}
