using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BikeRace
{
    public class ClientState : MonoBehaviour
    {
        private BikeController _bikeController;
        // Start is called before the first frame update
        void Start()
        {
            _bikeController = (BikeController)FindObjectOfType(typeof(BikeController));
        }

        private void OnGUI()
        {
            if (GUILayout.Button("startBike"))
            {
                _bikeController.StartBike();
            }
            if (GUILayout.Button("stopBike"))
            {
                _bikeController.StopBike();
            }
            if (GUILayout.Button("Turn right"))
            {
                _bikeController.Turn(Direction.right);
            }
            if (GUILayout.Button("Turn Left"))
            {
                _bikeController.Turn(Direction.left);
            }
        }
    }
}
