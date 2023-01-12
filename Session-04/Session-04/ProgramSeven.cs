using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ProgramSeven
    {

        double celsius = 25.5;

        public double CelsiusToKelvin()
        {
            double kelvin = celsius + 273;
            return kelvin;
        }
        public double CelsiusToFahrenheit()
        {
            double fahrenheit = celsius * 18 / 10 + 32;
            return fahrenheit;
        }
    }
}
