using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{

    public enum PrioridadTicket
    {
        Baja,
        Media,
        Alta
    }
    
    public enum EstadoTicket
    {
        Abierto,
        Cerrado,
        Cancelado,
        EnProceso,
        DerivadoBackoffice,
        DerivadoTecnico,
    }

    public enum EstadoServicio
    {
        Activo,
        Inactivo,
        PendienteInstalacion,
        Indefinido
    }

    public enum EstadoNodo
    {
        Operacional,
        FallaReportada,
        EnReparacion,
        Caido,
        ServicioDegradado
    }
        
    public enum TipoEmpleado
    {
        Administrador = 1,
        RepresentanteDeSoporte = 2,
        RepresentanteDeBackOffice = 3,
        CoordinadorBaseTecnica = 4,
        TecnicoDomiciliario = 5
    }

    public enum EstadoTurno
    {
        Disponible,
        Tomado,
        Cancelado
    }

    public enum FranjaHoraria
    {
       Mañana,
       Tarde
    }

    public enum TipoOrdenTecnica {
        Instalacion,
        Reparacion,
        Mantenimiento,
        Mudanza,
        Recambio
    }
    
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
        CRUDInteraccion,
        CRUDTurno,
        CRUDOrdenTecnica
    }
}
