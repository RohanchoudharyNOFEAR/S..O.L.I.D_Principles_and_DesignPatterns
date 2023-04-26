using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientEventBus : MonoBehaviour
{
    private bool _isButtonEnabled;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<HUDController>();
        gameObject.AddComponent<CountDownTimer>();
        gameObject.AddComponent<BikeController>();
        _isButtonEnabled = true;
    }

    private void OnEnable()
    {
        EventBus.Subscribe(RaceEventType.Stop, Restart);
    }
    private void OnDisable()
    {
        EventBus.Unsubscribe(RaceEventType.Stop, Restart);
    }

    void Restart()
    {
        _isButtonEnabled = true;
    }

    private void OnGUI()
    {
        if(_isButtonEnabled)
        {
            if(GUILayout.Button("start Countdown"))
            {
                _isButtonEnabled = false;
                EventBus.Publish(RaceEventType.CountDown);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
