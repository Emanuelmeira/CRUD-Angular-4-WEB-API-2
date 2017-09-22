using Domain.Context;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T>
    {        
        List<T> GetAll();
        void Save(T Entity);
        void Update(T Entity);
        T GetById(int id);
        T Delete(int id);        
    }
}
