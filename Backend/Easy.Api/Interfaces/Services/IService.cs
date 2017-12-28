using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Api.Interfaces.Services
{
    public interface IService<T>
    {
        List<T> GetAll();
        void Save(T Entity);
        void Update(T Entity);
        T GetById(int id);
        T Delete(int id);
        
    }
}
