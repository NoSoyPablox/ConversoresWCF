using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    [ServiceContract]
    internal interface IServicioTemperatura
    {
        [OperationContract]
        float obtenerFahrenheit(float celsius);
        [OperationContract]
        float obtenerCelsius(float fahrenheit);
    }
}
