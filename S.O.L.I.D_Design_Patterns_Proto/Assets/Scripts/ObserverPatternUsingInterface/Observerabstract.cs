using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverAbstract
{
    public abstract class Observerabstract : MonoBehaviour
    {
        public abstract void Notify(Subjectabstract subjectabstract);
    }

}