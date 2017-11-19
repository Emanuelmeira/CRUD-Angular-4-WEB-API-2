using System.Collections.Generic;

namespace Projeto.Infra.Interfaces
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
