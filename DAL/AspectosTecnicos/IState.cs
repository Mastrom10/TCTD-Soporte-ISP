using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using SERV;

namespace DAL
{
    public interface IState<T> where T : IEntity
    {
        void SaveState(State<T> estado);

        List<State<T>> getStates(T entity);
    }
}
