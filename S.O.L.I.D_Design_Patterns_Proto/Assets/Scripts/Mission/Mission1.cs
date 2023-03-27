using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mission1 : MissionBase
{
   // public string title;
   // public string description;
  //  public bool isMissionComplete;
   // public List<Objective> Objectives;


    public override void OnStart()
    {
        base.OnStart();
        isMissionComplete = false;
    }
    

    public override void OnUpdate()
    {
        base.OnUpdate();
        if(isMissionComplete)
        {
            return;
        }
        checkObjectives();
    }

    void checkObjectives()
    {
        bool allObjectivesComplete = true;

        foreach (Objective objective in Objectives)
        {
            if (objective.isComplete == false)
            {
                if (objective.objectiveName == "Reach on target pos")
                {
                    if (PlayerMissionsChecks.TargetReachecdObjectiveComplete)
                    {
                        objective.isComplete = true;
                        Debug.Log("target Reached");
                    }
                    else
                    {
                        allObjectivesComplete = false;
                    }
                }
                else if (objective.objectiveName == "Jump")
                {
                    if (PlayerMissionsChecks.JumpedObjectiveComplete)
                    {
                        objective.isComplete = true;
                        Debug.Log("Jumped ");
                    }
                    else
                    {
                        allObjectivesComplete = false;
                    }
                }
                else
                {
                    allObjectivesComplete = false;
                }
            }
        }
        if (allObjectivesComplete == true)
        {
            isMissionComplete = true;
            Debug.Log("mission completed");
        }
    }

}
