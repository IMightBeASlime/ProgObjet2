using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_exercice3
{
    public interface IFraction
    {

        void Simplifier();
        Fraction Additionner(Fraction a, Fraction b);
        Fraction Soustraire(Fraction a, Fraction b);
        Fraction Multiplier(Fraction a, Fraction b);
    }
}
