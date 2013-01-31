using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AppWS.Dominio;
using AppWS.Persistencia;

namespace AppWS
{
    public class AdmHobbie : IAdmHobbie
    {
        private HobbieDAO hobbieDAO = null;
         
        private HobbieDAO HobbieDAO
        {
            get
            {
                if (hobbieDAO == null)
                    hobbieDAO = new HobbieDAO();
                return hobbieDAO;
            }
        }

        public Hobbie crear(string nombre, string descripcion)
        {
            Hobbie o = new Hobbie()
            {
                Nombre = nombre,
                Descripcion = descripcion,
            };
            return HobbieDAO.Crear(o);
        }


        public Hobbie  obtenerNombre(int  codigo)
        {
            return HobbieDAO.ObtenerNombre(codigo);
        }

        public List<Hobbie> listar()
        {
            return HobbieDAO.ListarTodos().ToList();
        }
    }
}
