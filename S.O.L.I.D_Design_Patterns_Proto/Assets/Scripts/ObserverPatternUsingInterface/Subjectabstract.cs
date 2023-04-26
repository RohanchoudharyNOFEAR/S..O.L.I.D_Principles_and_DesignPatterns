using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverAbstract
{
    public abstract class Subjectabstract : MonoBehaviour
    {
        private readonly ArrayList _observers = new ArrayList();

        public void Attach(Observerabstract observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observerabstract observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (Observerabstract observer in _observers)
            {
                observer.Notify(this);
            }
        }

    }
}
