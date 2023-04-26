using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisiterPattern
{
    public interface IVisitor 
    {
        void visit(BikeShield bikeShield);
        void visit(BikeWeapon bikeWeapon);
        void visit(BikeEngine bikeEngine);
    }
}
