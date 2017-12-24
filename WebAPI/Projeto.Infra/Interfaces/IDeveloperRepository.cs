using Easy.Domain.Entities;
using System.Collections.Generic;

namespace Projeto.Infra.Interfaces
{
    public interface IDeveloperRepository
    {   
        List<Developer> GetAll();
        void Save(Developer Entity);
        void Update(Developer Entity);
        Developer GetById(int id);
        Developer Delete(int id);        
    }
}
