using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ObjectiveSO",menuName = " Create Objectives")]
public class Objective : ScriptableObject
{
    public string objectiveName;
    public string objectiveDescription;
    public int completionCriteria;
    public int rewardPoints;
    public bool isComplete;
}
