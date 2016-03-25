using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Sibling
    {
        private string years;
        private string month;
        private string days;
        private DateTime age;

        public Sibling(DateTime dob)
        {
            DateTime presentYear = DateTime.Now;
            TimeSpan ts = presentYear - dob;
            age = new DateTime() + ts;
            years = (age.Year-1).ToString();
            month = (age.Month-1).ToString();
            days = (age.Day-1).ToString();
        }
        
        public void showAge()
        {
            Console.WriteLine(" {0} Years {1} Month {2} Days", years, month, days);
        }
        public DateTime getAge()
        {
            return age;
        }

    }
}
