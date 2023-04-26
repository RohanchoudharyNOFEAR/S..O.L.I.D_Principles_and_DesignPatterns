using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    private DateTime _sessionStartTime;
    private DateTime _sessionEndTime;

    private void Start()
    {
        _sessionStartTime = DateTime.Now;
        Debug.Log("$session starts at{_sessionStartTime}");
    }

    private void OnApplicationQuit()
    {
        _sessionEndTime = DateTime.Now;
        TimeSpan timeSpan = _sessionEndTime.Subtract(_sessionStartTime);
        Debug.Log("$session time at{timeSpan}");
        Debug.Log("$session ends at{_sessionEndTime}");

    }

    private void OnGUI()
    {
        EditorGUILayout.Space(110);
        if (GUILayout.Button("NextScene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
     
    }
   

}
