using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        private Random RND;

        public Vasember() : base(150, true)
        {
            RND = new Random();
        }

        public void KutyutKeszit()
        {
            this.Szuperero += RND.NextDouble() * 10;
        }

        public override bool MegmentiAVilagot()
        {
            if (this.Szuperero > 1000)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Vasember: " + base.ToString();
        }
    }
}
