using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public abstract class Bosszuallo : ISzuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        protected Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            this.szuperero = szuperero;
            this.vanEGyengesege = vanEGyengesege;
        }

        public double Szuperero { get => szuperero; set => szuperero = value; }
        public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

        public bool LegyoziE(ISzuperhos szuperhos)
        {
            if (szuperhos is Batman)
            {
                if ((szuperhos as Batman)!.MekkoraAzEreje() * 2 <= this.Szuperero)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if ((szuperhos as Bosszuallo)!.vanEGyengesege == true && this.szuperero > szuperhos.MekkoraAzEreje())
                {
                    return true;
                }
                return false;
            }
        }

        public double MekkoraAzEreje()
        {
            return this.szuperero;
        }

        public abstract bool MegmentiAVilagot();

        public override string ToString()
        {
            if (this.VanEGyengesege)
            {
                return $"Szupererő: {szuperero}; van gyengesége";
            }
            return $"Szupererő: {szuperero}; nincs gyengesége";
        }
    }
}
