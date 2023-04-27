using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Conversores
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioDivisas
    {
        [OperationContract]
        float obtenerMXN(float usd);
        [OperationContract]
        float obtenerUSD(float mxn);
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "ConvertorDivisa.ContractType".
}
