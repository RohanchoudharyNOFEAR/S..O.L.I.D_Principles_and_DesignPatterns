using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler: MonoBehaviour
{
    private Invoker _invoker;
    private bool _isRecording;
    private bool _isReplaying;
    private BikeControllerForCommand _bikeController;
    private Command _buttonA, _buttonD, _buttonW;

    private void Start()
    {
        _invoker = gameObject.AddComponent<Invoker>();
        _bikeController = FindObjectOfType<BikeControllerForCommand>();
        _buttonA = new TurnLeft(_bikeController);
        _buttonD = new TurnRight(_bikeController);
        _buttonW = new ToggleTurbo(_bikeController);
    }

    private void Update()
    {
        if (!_isReplaying && _isRecording)
        {
            if (Input.GetKeyUp(KeyCode.A))
            {
                _invoker.ExecuteCommand(_buttonA);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                _invoker.ExecuteCommand(_buttonD);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                _invoker.ExecuteCommand(_buttonW);
            }
        }
    }

    private void OnGUI()
    {
        if (GUILayout.Button("start recording"))
        {
            _bikeController.ResetPosition();
            _isReplaying = false;
            _isRecording = true;
            _invoker.Record();
        }
        if (GUILayout.Button("Stop recording"))
        {
            _bikeController.ResetPosition();
            _isRecording = false;
        }
        if(!_isRecording)
        {
            if(GUILayout.Button("Start Replay"))
            {
                _bikeController.ResetPosition();
                _isReplaying = true;
                _isRecording = false;
                _invoker.Replay();
            }
        }

    }

}
