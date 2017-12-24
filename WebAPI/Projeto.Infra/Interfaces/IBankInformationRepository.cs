using Domain.Entities;
using System.Collections.Generic;

namespace Projeto.Infra.Interfaces
{
    public interface IBankInformationRepository
    {   
        List<BankInformation> GetAll();
        void Save(BankInformation Entity);
        void Update(BankInformation Entity);
        BankInformation GetById(int id);
        BankInformation Delete(int id);        
    }
}
