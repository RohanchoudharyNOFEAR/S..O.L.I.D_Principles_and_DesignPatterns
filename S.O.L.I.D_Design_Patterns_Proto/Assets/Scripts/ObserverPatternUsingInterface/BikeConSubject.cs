using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ObserverAbstract
{


    public class BikeConSubject : Subjectabstract
    {
        public bool IsTurboOn { get; private set; }
        public float CurrentHealth { get { return health; } }
        [SerializeField] private float health = 100f;
        private bool _isEngineOn;
        private HUDCon _hudCon;private CameraCon _cameraCon;
        private void Awake()
        {
            _hudCon = gameObject.AddComponent<HUDCon>();
            _cameraCon = (CameraCon)FindObjectOfType(typeof(CameraCon));

        }
        private void Start()
        {
            StartEngine();
        }

        private void OnEnable()
        {
            if (_hudCon) Attach(_hudCon);
            if (_cameraCon) Attach(_cameraCon);
        }
        private void OnDisable()
        {
            if (_hudCon) Detach(_hudCon);
            if (_cameraCon) Detach(_cameraCon);
        }

        private void StartEngine()
        {
            _isEngineOn = true;
            NotifyObservers();

        }

        public void ToggleTurbo()
        {
            if (_isEngineOn) IsTurboOn = !IsTurboOn;
            NotifyObservers();
        }

        public void TakeDamage(float amount)
        {
            health -= amount;
            IsTurboOn = false;
            NotifyObservers();
            if(health<0)
            {
                Destroy(gameObject);
            }

        }
    }
}
