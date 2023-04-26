using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratagy
{
    public class FallBackManeuver : MonoBehaviour, IManeuverBehaviour
    {
        public void Maneuver(DroneCon drone)
        {
            StartCoroutine(Fallback(drone));
        }

        IEnumerator Fallback(DroneCon drone)
        {
            float time = 0;
            float speed = drone.speed;
            Vector3 startPosition = drone.transform.position;
            Vector3 endPosition = startPosition;
            endPosition.z = drone.fallbackDistance;

            while (time < speed)
            {
                drone.transform.position =
                    Vector3.Lerp(
                        startPosition, endPosition, time / speed);

                time += Time.deltaTime;

                yield return null;
            }
        }
    }
}
