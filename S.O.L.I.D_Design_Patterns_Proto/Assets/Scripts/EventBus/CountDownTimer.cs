using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{
    private float _currentTime;
    private float _duration = 3f;

    private void OnEnable()
    {
        EventBus.Subscribe(RaceEventType.CountDown, startTimer);
    }
    private void OnDisable()
    {
        EventBus.Unsubscribe(RaceEventType.CountDown, startTimer);
    }

    private void startTimer()
    {
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        _currentTime = _duration;
        while (_currentTime > 0)
        {
            yield return new WaitForSeconds(1f);
            _currentTime--;
        }
        EventBus.Publish(RaceEventType.Start);
    }

    void OnGUI()
    {
        GUI.color = Color.blue;
        GUI.Label(new Rect(125,0,100,20),"countdown" + _currentTime);
    }

}
