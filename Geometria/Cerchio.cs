using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Cerchio
    {
        public const double PI = 3.14;
        private double raggio;

        public Cerchio(double r)
        {
            r = raggio;
        }
        public double CalcolaCirconferenza()
        {
            return 2 * PI * raggio;
        }
        public double CalcolaArea()
        {
            return PI*raggio * raggio;
        }
        public void CambiaRaggio(double nuovoRaggio)
        {
            if (nuovoRaggio > 0)
                raggio = nuovoRaggio;
            throw new Exception("Raggio non valido");

        }
        public double DammiRaggio()
        {
            return raggio;
        }
        public string StampaStringa()
        {
            return $"Cerchio(r={raggio},"+$"circonferenza={CalcolaCirconferenza()},"+$"area={CalcolaArea()})";
        }
    }
}
