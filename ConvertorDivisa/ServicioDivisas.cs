using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Conversores
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServicioDivisas : IServicioDivisas
    {
        public float obtenerMXN(float usd)
        {
            float tasaCambio = 20.0f; // Aquí se asume una tasa de cambio de 20 pesos por dólar
            float pesos = usd * tasaCambio;
            return pesos;
        }

        public float obtenerUSD(float mxn)
        {
            float tasaCambio = 0.05f; // Aquí se asume una tasa de cambio de 0.05 dólares por peso mexicano
            float usd = mxn * tasaCambio;
            return usd;
        }
    }
}
