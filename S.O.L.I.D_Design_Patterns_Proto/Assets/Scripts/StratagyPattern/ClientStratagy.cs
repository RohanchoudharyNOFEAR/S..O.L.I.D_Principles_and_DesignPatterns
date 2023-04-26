using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratagy
{
    public class ClientStratagy : MonoBehaviour
    {
        private GameObject _drone;
        private List<IManeuverBehaviour>
            _components = new List<IManeuverBehaviour>();

        private void SpawnDrone()
        {
            _drone =
                GameObject.CreatePrimitive(PrimitiveType.Cube);

            _drone.AddComponent<DroneCon>();

            _drone.transform.position =
                Random.insideUnitSphere * 10;

            ApplyRandomStrategies();
        }

        private void ApplyRandomStrategies()
        {
            _components.Add(
                _drone.AddComponent<WeavingManeuver>());
            _components.Add(
                _drone.AddComponent<BoppingManeuver>());
            _components.Add(
                _drone.AddComponent<FallBackManeuver>());

            int index = Random.Range(0, _components.Count);

            _drone.GetComponent<DroneCon>().
                ApplyStrategy(_components[index]);
        }

        void OnGUI()
        {
            if (GUILayout.Button("Spawn Drone"))
            {
                SpawnDrone();
            }
        }
    }
}