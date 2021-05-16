using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Fysikz.NucleonEngine.Collections
{
    public class CheckedCollisions
    {
        public NucleonCollider A, B;

        public CheckedCollisions(NucleonCollider A, NucleonCollider B)
        {
            this.A = A;
            this.B = B;
        }

        public bool HasChecked(NucleonCollider CheckingA, NucleonCollider CheckingB)
        {
            if (CheckingA == B || CheckingB == A)
                return true;
            else
                return false;
        }

        public bool HasChecked(NucleonCollider A)
        {
            if (A == this.A || A == this.B)
                return true;
            else
                return false;
        }
    }
}
