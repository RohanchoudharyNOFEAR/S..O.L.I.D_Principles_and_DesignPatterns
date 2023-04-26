using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverAbstract
{
    public class ClientObserver : MonoBehaviour
    {
        private BikeConSubject _bikeController;

        void Start()
        {
            _bikeController =
                (BikeConSubject)
                FindObjectOfType(typeof(BikeConSubject));
        }

        void OnGUI()
        {
            if (GUILayout.Button("Damage Bike"))
                if (_bikeController)
                    _bikeController.TakeDamage(15.0f);

            if (GUILayout.Button("Toggle Turbo"))
                if (_bikeController)
                    _bikeController.ToggleTurbo();
        }
    }
}
