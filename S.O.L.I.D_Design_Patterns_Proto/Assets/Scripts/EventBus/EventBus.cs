using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum RaceEventType { CountDown,Start,Stop,Restart,Pause,Finish,Quit}

public class EventBus : MonoBehaviour
{
    private static readonly IDictionary<RaceEventType, UnityEvent> Events = new Dictionary<RaceEventType, UnityEvent>();

    public static void Subscribe(RaceEventType eventType,UnityAction listner)
    {
        UnityEvent thisEvent;
        if(Events.TryGetValue(eventType,out thisEvent))
        {
            thisEvent.AddListener(listner);
        }
        else
        {
            thisEvent = new UnityEvent();
            thisEvent.AddListener(listner);
            Events.Add(eventType, thisEvent);
        }
    }
public static void Unsubscribe(RaceEventType eventType,UnityAction listner)
    {
        UnityEvent thisevent;
        if(Events.TryGetValue(eventType,out thisevent))
        {
            thisevent.RemoveListener(listner);
        }
    }

    public static void Publish(RaceEventType eventType)
    {
        UnityEvent thisEvent;
        if(Events.TryGetValue(eventType,out thisEvent))
        {
            thisEvent.Invoke();
        }
    }

}
