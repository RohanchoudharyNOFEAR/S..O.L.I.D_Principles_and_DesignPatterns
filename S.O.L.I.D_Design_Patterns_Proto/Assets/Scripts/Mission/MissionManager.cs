using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
   

    public List<MissionBase> missions;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        foreach (MissionBase mission in missions)
        {
            if (!mission.isMissionComplete)
            {
                
               
                  //  CompleteMission(mission);
               // Debug.Log(mission + "completed");
            }
        }

    }
    public void AddMission(MissionBase mission)
    {
        missions.Add(mission);
    }

    public void RemoveMission(MissionBase mission)
    {
        missions.Remove(mission);
    }

    public void CompleteMission(MissionBase mission)
    {
        mission.isMissionComplete = true;
    }

    public bool IsMissionComplete(MissionBase mission)
    {
        return mission.isMissionComplete;
    }

    public bool AreAllMissionsComplete()
    {
        foreach (MissionBase mission in missions)
        {
            if (!mission.isMissionComplete)
            {
                return false;
            }
        }

        return true;
    }


}
