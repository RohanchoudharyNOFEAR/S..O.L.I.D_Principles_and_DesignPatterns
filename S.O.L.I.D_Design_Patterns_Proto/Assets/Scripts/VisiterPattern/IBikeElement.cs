using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisiterPattern
{
    public interface IBikeElement
    {
        void Accept(IVisitor visitor);
    }
}
