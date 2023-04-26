using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverAbstract
{
    public class CameraCon : Observerabstract
    {
        private bool _isTurboOn;
        private Vector3 _initialPosition;
        private float _shakeMagnitude = 0.1f;
        private BikeConSubject _bikeController;

        void OnEnable()
        {
            _initialPosition =
                gameObject.transform.localPosition;
        }

        void Update()
        {
            if (_isTurboOn)
            {
                gameObject.transform.localPosition =
                    _initialPosition +
                    (Random.insideUnitSphere * _shakeMagnitude);
            }
            else
            {
                gameObject.transform.
                    localPosition = _initialPosition;
            }
        }

        public override void Notify(Subjectabstract subject)
        {
            if (!_bikeController)
                _bikeController =
                    subject.GetComponent<BikeConSubject>();

            if (_bikeController)
                _isTurboOn = _bikeController.IsTurboOn;
        }
    }
}
