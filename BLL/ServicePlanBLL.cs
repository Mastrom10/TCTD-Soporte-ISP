using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using SERV;
using DAL;

namespace BLL
{
    public class ServicePlanBLL : GenericBLL<ServicePlan>
    {
        public ServicePlanBLL() 
        {
            dal = new ServicePlanDAL();
            permiso = TipoPermiso.CRUDServicePlan;
        }
    }
}
