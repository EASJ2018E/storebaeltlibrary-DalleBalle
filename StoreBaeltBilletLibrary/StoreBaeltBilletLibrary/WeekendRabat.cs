using System;
using BilletOpg;

namespace StoreBaeltBilletLibrary
{
    public static class WeekendRabat
    {
        public static decimal WeekendPrisBil(decimal pris)
        {
            decimal rabat = pris * (decimal) 0.2;
            return pris - rabat;
        }
    }
}
