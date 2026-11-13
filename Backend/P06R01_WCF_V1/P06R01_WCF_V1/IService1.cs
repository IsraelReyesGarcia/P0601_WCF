using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel; // IMPORTA LAS CLASES NECESARIAS PARA CREAR UN WCF
using System.ServiceModel.Web;
using System.Text;

namespace P06R01_WCF_V1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract] // INDICA QUE LA INTERFAZ DEFINIE UN CONTRATO DE SERVICIO WCF
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
        // El MÉTODO SEA ACCESIBLE DESDE EL CLIENTE WCF, POR LO QUE SE DEBE DEFINIR EN LA INTERFAZ DEL SERVICIO
        [OperationContract] // INDICA QUE EL MÉTODO DEFINE UNA OPERACIÓN DE SERIVICIO WCF
        List<string> ObtenerUsuarios();
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
