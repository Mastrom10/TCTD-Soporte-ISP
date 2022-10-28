using System;
using System.Collections.Generic;
using DAL;
using SERV.MultiIdioma;
using BE;
using SERV;

namespace BLL
{
    public class TraduccionBLL : GenericBLL<Traduccion>
    {
        TraduccionDAL tDAL;
        
            
        public TraduccionBLL() {
            tDAL = new TraduccionDAL();
            dal = tDAL;
            permiso = TipoPermiso.CRUDTraduccion;
        }

        public List<Traduccion> GetAllByIdioma(Idioma idioma)
        {
            return tDAL.GetAllByIdioma(idioma);
        }

        public void UpdateMany(List<Traduccion> traducciones)
        {
            TipoPermiso permisoEspecifico = TipoPermiso.UpdateManyIdioma;
            if (!Session.GetSession().TienePermiso(permisoEspecifico))
            {
                logger.Log("El usuario no tiene permiso para Actualizar Idiomas", LogLevel.Warning, null, "TraduccionBLL", "UpdateMany");
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
            }
            
            foreach (Traduccion t in traducciones)
            {
                if (t.traduccion != null && t.traduccion.Length > 0)
                {
                    tDAL.Update(t);
                }
            }
            logger.Log("Se actualizaron las traducciones", LogLevel.Info, SERV.Serializacion.LogSerializer.Serialize(traducciones), "TraduccionBLL", "UpdateMany");
            Session.CambiarIdioma();
        }
    }
}
