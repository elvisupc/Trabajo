using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using AppWS.Dominio;

namespace AppWS.Persistencia
{
    public class BaseDAO <Entidad,  Id>
    {
        public Entidad Crear(Entidad entidad)
        {
           try
            {
                using (ISession sesion = NHibernateHelper.ObtenerSesion())
                {
                    sesion.Save(entidad);
                    sesion.Flush();
                }
                return entidad;
            }
            catch
            {
               
                Console.WriteLine("Ya existe Registro");
                return  entidad;
            }
        }

        public Entidad ObtenerNombre(Id id)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                return sesion.Get<Entidad>(id);
            }
        }

        public Entidad Modificar(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                sesion.Update(entidad);
                sesion.Flush();
            }
            return entidad;
        }

        public void Eliminar(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                sesion.Delete(entidad);
                sesion.Flush();
            }
        }

        public ICollection<Entidad> ListarTodos()
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICriteria busqueda = sesion.CreateCriteria(typeof(Entidad));
                return busqueda.List<Entidad>();
            }
        }
     
    }
}