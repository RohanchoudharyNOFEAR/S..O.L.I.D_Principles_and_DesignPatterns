using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BikeRace
{
    public interface IBikeState
    {
        void Handle(BikeController controller);
       
    }

}