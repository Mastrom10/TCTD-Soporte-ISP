using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum TipoPermiso
    {
        CRUDUsuario,
        CRUDAdmin,
        CRUDTraduccion,
        UpdateManyIdioma,
        CRUDPermiso,
        CrearUsuario,
        MostrarMensajeProtegido,
        PermisoDesvincularPadreHijo,
        PermisoVincularPadreHijo,
        QuitarPermisoAUsuario,
        PermisoAgregarPermisoAUsuario,
        PermisoObtenerPermisosPorUsuario,
        PermisoEliminarPermisos,
        PermisoCrearGrupos,
        CRUDIdioma,
        IdiomaSeleccionarIdioma,
        CRUDNodoRed,
        CRUDServicePlan,
        CRUDDispositivo,
        CRUDDireccion,
        CRUDServicio,
        CRUDCliente,
        CRUDTicket,
        CRUDInteraccion
    }
}
