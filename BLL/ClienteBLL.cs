using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using SERV;

namespace BLL
{
    public class ClienteBLL : GenericBLL<Cliente>
    {
        public ClienteBLL()
        {
            this.dal = new ClienteDAL();
            this.permiso = TipoPermiso.CRUDCliente;
        } 

        public Cliente getByDNI(string dni)
        {
           if (!Session.GetSession().TienePermiso(this.permiso))
            {
                logger.Log("El usuario  no tiene permiso para buscar clientes por DNI", LogLevel.Warning, null, "ClienteBLL", "getByDNI");
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + this.permiso.ToString());
            }

            Cliente cliente = ((ClienteDAL)dal).GetByDni(dni);
            if (cliente == null)
            {
                logger.Log("No se encontro el cliente con DNI " + dni, LogLevel.Warning, null, "ClienteBLL", "getByDNI");
                throw new Exception("No se encontro el cliente con DNI " + dni);
            }
            logger.Log("Se obtuvo un registro de cliente por el DNI " + dni, LogLevel.Debug, SERV.Serializacion.LogSerializer.Serialize(cliente), "ClienteBLL", "getByDNI");
            return cliente;
        }

        public override void Create(Cliente entity)
        {
            base.Create(entity);
            State<Cliente> state = new State<Cliente>() { 
                entity = entity, 
                fecha = DateTime.Now, 
                tipoCambio = TipoCambio.Create, 
                usuario = Session.GetSession().usuario
            };
            ((ClienteDAL)dal).SaveState(state);

        }

        public override void Update(Cliente entity)
        {
            base.Update(entity);
            State<Cliente> state = new State<Cliente>()
            {
                entity = entity,
                fecha = DateTime.Now,
                tipoCambio = TipoCambio.Update,
                usuario = Session.GetSession().usuario
            };
            ((ClienteDAL)dal).SaveState(state);
        }

        public override void Delete(Cliente entity)
        {
            base.Delete(entity);
            State<Cliente> state = new State<Cliente>()
            {
                entity = entity,
                fecha = DateTime.Now,
                tipoCambio = TipoCambio.Delete,
                usuario = Session.GetSession().usuario
            };
            ((ClienteDAL)dal).SaveState(state);
        }

        public void Restore(State<Cliente> state) {
            base.Update(state.entity);
            State<Cliente> newstate = new State<Cliente>()
            {
                entity = state.entity,
                fecha = DateTime.Now,
                tipoCambio = TipoCambio.Restore,
                usuario = Session.GetSession().usuario
            };
            ((ClienteDAL)dal).SaveState(newstate);
            logger.Log(LogLevel.Warning, "Se Restauro el Cliente ID:" + state.entity.Id + " al estado anterior: " + state.ToStringList, SERV.Serializacion.LogSerializer.Serialize(newstate), this.GetType().ToString(), System.Reflection.MethodBase.GetCurrentMethod().Name);


        }

        public List<State<Cliente>> GetStates(Cliente cliente)
        {
            return ((ClienteDAL)dal).getStates(cliente);
        }

    }
}
