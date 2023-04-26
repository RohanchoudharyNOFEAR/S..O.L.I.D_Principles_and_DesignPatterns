using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    private bool _isRecording;
    private bool _isReplaying;
    private float _replayTime;
    private float _recordingTime;

    private SortedList<float, Command> _recordedCommand = new SortedList<float, Command>();

    public void ExecuteCommand(Command command)
    {
        command.Execute();
        if(_isRecording)
        {
            _recordedCommand.Add(_recordingTime, command);
        }
        Debug.Log("recorded time: " + _recordingTime);
        Debug.Log("recorded command: " + command);
    }

    public void Record()
    {
        _isRecording = true;
        _recordingTime = 0f;
    }

    public void Replay()
    {
        _replayTime = 0f;
        _isReplaying = true;
        if(_recordedCommand.Count<=0)
        {
            Debug.LogError("No Commands To Replay!");

        }
        _recordedCommand.Reverse();

    }

    private void FixedUpdate()
    {
        if(_isRecording)
        {
            _recordingTime += Time.fixedDeltaTime;
        }
        if(_isReplaying)
        {
            _replayTime += Time.deltaTime;
            if(_recordedCommand.Any())
            {
                if(Mathf.Approximately(_replayTime,_recordedCommand.Keys[0]))
                {
                    Debug.Log("Replay time" + _replayTime);
                    Debug.Log("replay command" + _recordedCommand.Values[0]);
                    _recordedCommand.Values[0].Execute();
                    _recordedCommand.RemoveAt(0);
                }
            }
        }
        else
        {
            _isReplaying = false;
        }
    }


}
