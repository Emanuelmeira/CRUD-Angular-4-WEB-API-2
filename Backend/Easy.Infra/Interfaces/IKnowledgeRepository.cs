using Easy.Domain.Entities;
using System.Collections.Generic;

namespace Easy.Infra.Interfaces
{
    public interface IKnowledgeRepository
    {   
        List<Knowledge> GetAll();
        void Save(Knowledge Entity);
        void Update(Knowledge Entity);
        Knowledge GetById(int id);
        Knowledge Delete(int id);        
    }
}
