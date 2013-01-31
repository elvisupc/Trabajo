using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AppWS.Dominio;

namespace AppWS
{
    [ServiceContract]
    public interface IAdmHobbie
    {
        [OperationContract]
        Hobbie crear(string nombre, string descripcion);
        [OperationContract]
        List<Hobbie> listar();
        [OperationContract]
        Hobbie obtenerNombre(int codigo);
    }
}
