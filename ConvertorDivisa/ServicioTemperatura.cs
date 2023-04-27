using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    public class ServicioTemperatura : IServicioTemperatura
    {
        public float obtenerCelsius(float fahrenheit)
        {
            float celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }

        public float obtenerFahrenheit(float celsius)
        {
            float fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
    }
}
