﻿using Easy.Domain.Entities;
using Easy.Infra.Context;
using Easy.Infra.Exceptions;
using Easy.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Easy.Infra.Repository
{
    public class BankInformationRepository : IBankInformationRepository
    {                
        private EFContext Context;

        public BankInformationRepository()
        {
            Context = EFContext.ContextFactory();
        }
        
        //UPDATE BankInformation
        public void Update(BankInformation BankInformation)
        {
            try
            {                                
                Context.BankInformation.Attach(BankInformation);
                Context.Entry(BankInformation).State = EntityState.Modified;                
                Context.SaveChanges(); 

            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }            
        }              
                
        public void Save(BankInformation BankInformation)
        {
            throw new NotImplementedException();
        }

        private BankInformation GetBankInformationById(int id)
        {
            throw new NotImplementedException();
        }

        public BankInformation Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BankInformation> GetAll()
        {
            throw new NotImplementedException();
        }

        public BankInformation GetById(int id)
        {
            throw new NotImplementedException();
        }


    }
}