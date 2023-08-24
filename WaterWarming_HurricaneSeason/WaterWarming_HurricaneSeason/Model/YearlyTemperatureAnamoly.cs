using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterWarming_HurricaneSeason
{
    public class YearlyTemperatureAnomaly
    {
        public DateTime Year { get; set; }
        public double Temperature { get; set; }

        public YearlyTemperatureAnomaly(DateTime year,double temperature) 
        {
            Year = year;
            Temperature = temperature;
        }
    }
}
