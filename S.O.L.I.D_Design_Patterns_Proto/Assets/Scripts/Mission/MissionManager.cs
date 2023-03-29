using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour
{


    public List<MissionBase> missions;
    public MissionBase currentMission;
    public Text missionText;
    public Text objectiveListText;

    // Start is called before the first frame update
    void Start()
    {
        foreach (MissionBase mission in missions)
        {
            mission.gameObject.SetActive(false);
        }
        currentMission = missions[0];
        currentMission.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        checkMission();
        UpdateObjectiveListText();


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

    void checkMission()
    {
        missionText.text = "Mission :" + currentMission.title;

        int index = 0;
        if (currentMission.isMissionComplete == true)
        {
            index++;
            currentMission.gameObject.SetActive(false);
            currentMission = missions[index];
            currentMission.gameObject.SetActive(true);
        }
    }

    void UpdateObjectiveListText()
    {
        string objectivesText = "";
        foreach (Objective objective in currentMission.Objectives)
        {
            objectivesText += objective.objectiveName + "\n ";
            if (objective.isComplete)
                objectivesText += "Complete!\n";
            //else
               // objectivesText += objective.completionCriteria + " remaining.\n";
        }
        objectiveListText.text = objectivesText;
    }

}
