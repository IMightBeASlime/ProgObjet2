using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_exercice3
{
    public class Fraction : IFraction
    {
        public int _numerateur { get; private set; }
        public int _denominateur { get; private set; }

        public Fraction(string fraction)
        {
            string[] morceaux = fraction.Split('/');
            _numerateur = int.Parse(morceaux[0]);
            _denominateur = int.Parse(morceaux[1]);
            Simplifier();
        }

        public Fraction(int numerateur, int denominateur)
        {
            _numerateur = numerateur;
            _denominateur = denominateur;
            Simplifier();
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            TrucDeMath trucDeMath = new TrucDeMath();
            int diviseurCommun = trucDeMath.PlusGrandDiviseurCommun(a._denominateur, b._denominateur);
            int numerateur = a._numerateur * (b._denominateur / diviseurCommun) + b._numerateur * (a._denominateur / diviseurCommun);
            int denominateur = a._denominateur * (b._denominateur / diviseurCommun);
            return new Fraction(numerateur, denominateur);
        }

        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a._numerateur, a._denominateur);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a + -b;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction resultat1 = new Fraction(a._numerateur, b._denominateur);
            Fraction resultat2 = new Fraction(b._numerateur, a._denominateur);
            return new Fraction(resultat1._numerateur * resultat2._numerateur, resultat1._denominateur * resultat2._denominateur);
        }

        public override string ToString()
        {
            return _numerateur.ToString() + "/" + _denominateur.ToString();
        }

        public void Simplifier()
        {
            if (_denominateur < 0)
            {
                _numerateur = -_numerateur;
                _denominateur = -_denominateur;
            }
        }

        public Fraction Additionner(Fraction a, Fraction b)
        {
            return a + b;
        }

        public Fraction Soustraire(Fraction a, Fraction b)
        {
            return a - b;
        }

        public Fraction Multiplier(Fraction a, Fraction b)
        {
            return a * b;
        }
    }
}
