using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign05
{
    class DateValidator
    {
        private const int MINIMUM_YEAR = 1900;

        public static bool Validate (string year, string month, string day)
        {
            string date = string.Join("/", year, month, day);

            // validates the date
            if (DateTime.TryParse(date, out DateTime temp) && temp.Year >= MINIMUM_YEAR)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
