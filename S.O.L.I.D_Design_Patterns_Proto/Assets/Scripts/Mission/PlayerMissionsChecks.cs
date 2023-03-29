using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMissionsChecks : MonoBehaviour
{
    private PlayerInputs _playerInputs;
    private CharacterController _cC;
    private int Jumps = 1;
    private bool _jumpedObjectiveComplete = false;
    public bool JumpedObjectiveComplete { get { return _jumpedObjectiveComplete; }  set { _jumpedObjectiveComplete = value; } }
    private bool _targetReachecdObjectiveComplete = false;
    public bool TargetReachecdObjectiveComplete { get { return _targetReachecdObjectiveComplete; } private set { _targetReachecdObjectiveComplete = value; } }
    // Start is called before the first frame update
    void Start()
    {
        _playerInputs = GetComponent<PlayerInputs>();
        _cC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        IsJumpedObjectiveComplete();
    }

    public void IsJumpedObjectiveComplete()
    {
       // int Jumps =0;

        if(_playerInputs.InputJump && _cC.isGrounded && _jumpedObjectiveComplete==false)
        {
            Jumps++;
            Debug.Log("jumps=" +Jumps);
            if (Jumps>=3)
            {
               
                _jumpedObjectiveComplete = true;
                Jumps = 0;
            }
            else
            {
                _jumpedObjectiveComplete = false;
            }
        }
      //  _jumpedObjectiveComplete = false;
    }

    

    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Target"))
       {
            Debug.Log("entered target");
            _targetReachecdObjectiveComplete = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag =="Target")
        {
            Debug.Log("entered target");
            _targetReachecdObjectiveComplete = true;
        }
    }

}
