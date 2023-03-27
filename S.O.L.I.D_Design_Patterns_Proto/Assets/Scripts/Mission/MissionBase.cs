using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MissionBase : MonoBehaviour
{
    public string title;
    public string description;
    public bool isMissionComplete;
    public List<Objective> Objectives;


    protected PlayerMissionsChecks PlayerMissionsChecks;


    private void Start()
    {
        PlayerMissionsChecks =GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMissionsChecks>();
        OnStart();
    }
    private void Update()
    {
        OnUpdate();
    }

    // Start is called before the first frame update
    public virtual void  OnStart()
    {
      
    }

    // Update is called once per frame
   public virtual void OnUpdate()
    {
        
    }
}
