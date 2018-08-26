using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorWynagrodzen
{
    public class Month
    {
        public string MonthName(int monthNumber)
        {
            string[] month = { "Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec",
                               "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień" };
            return(month[monthNumber - 1]);
        }
    }
}
