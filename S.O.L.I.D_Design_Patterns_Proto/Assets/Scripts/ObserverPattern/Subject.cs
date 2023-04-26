using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractSubject : MonoBehaviour
{
    public Mission1 M1;
    public Mission2 M2;
    public PlayerMissionsChecks _pmc;

    public delegate void d_OnMission1Complete();
    public static event d_OnMission1Complete OnMission1CompleteEvent;

    public delegate void d_OnMission2Complete();
    public static event d_OnMission2Complete OnMission2CompleteEvent;

    public delegate void d_OnJumping();
    public static event d_OnJumping OnJumpingEvent;

    public delegate void d_OnLevelStarts();
    public static event d_OnLevelStarts OnLevelStartsEvent;

    // Start is called before the first frame update
    void Start()
    {
        LevelStarted();
    }

    // Update is called once per frame
    void Update()
    {
        Mission1Complete();
        Mission2Complete();
        Jumping();
    }

    void LevelStarted()
    {
        if(OnLevelStartsEvent!=null)
        {
            OnLevelStartsEvent();
        }
    }

    void Mission1Complete()
    {
        if(M1.isMissionComplete==true)
        {if(OnMission1CompleteEvent!=null)
            {
                OnMission1CompleteEvent();
            }
           
        }
    }
    void Mission2Complete()
    {
        if (M2.isMissionComplete == true)
        {
            if (OnMission2CompleteEvent != null)
            {
                OnMission2CompleteEvent();
            }

        }
    }

    void Jumping()
    {
       

            if (_pmc.Jump == 2)
            {
                if (OnJumpingEvent != null)
                {
                    OnJumpingEvent();
                }
            }
        
    }

}
