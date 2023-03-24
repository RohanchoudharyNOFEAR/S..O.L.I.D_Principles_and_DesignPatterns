using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    public Vector3 InputMovementVector { get; private set; }
    public Vector2 InputMouseVector { get; private set; }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        getInputs();
        getCameraInputs();
    }

    void getInputs()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float Verical = Input.GetAxis("Vertical");

        InputMovementVector = new Vector3(horizontal, 0, Verical);
    }
    void getCameraInputs()
    {
        float _mouseX, _mouseY;
        _mouseX = Input.GetAxis("Mouse Y");
        _mouseY = Input.GetAxis("Mouse X");
        InputMouseVector = new Vector2(_mouseX, _mouseY);
       // Debug.Log(InputMouseVector);
    }

}






