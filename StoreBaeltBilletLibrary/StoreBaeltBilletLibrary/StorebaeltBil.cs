using System;
using System.Collections.Generic;
using System.Text;
using BilletOpg;

namespace StoreBaeltBilletLibrary
{
    public class StorebaeltBil : Bil
    {
        public StorebaeltBil(string nummerplade, DateTime dato, bool brobizz) : base(nummerplade, dato, brobizz)
        {
        }

        public override decimal Pris()
        {
            decimal pris = 240;
            
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                pris = WeekendRabat.WeekendPrisBil(pris);
            }

            if (Brobizz)
            {
                pris = BrobizzRabatPris(pris);
            }

            return pris;
        }
    }
}
