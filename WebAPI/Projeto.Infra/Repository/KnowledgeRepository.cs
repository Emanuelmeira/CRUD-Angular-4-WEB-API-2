﻿using Domain.Entities;
using Projeto.Infra.Context;
using Projeto.Infra.Exceptions;
using Projeto.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Projeto.Infra.Repository
{
    public class KnowledgeRepository : IKnowledgeRepository
    {                
        private EFContext Context;

        public KnowledgeRepository()
        {
            Context = EFContext.ContextFactory();
        }
        
        //UPDATE Knowledge
        public void Update(Knowledge Knowledge)
        {
            try
            {                                
                Context.Knowledge.Attach(Knowledge);
                Context.Entry(Knowledge).State = EntityState.Modified;                
                Context.SaveChanges(); 

            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
            
        }               
                
        public void Save(Knowledge Knowledge)
        {
            throw new NotImplementedException();
        }

        private Knowledge GetKnowledgeById(int id)
        {
            throw new NotImplementedException();
        }

        public Knowledge Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Knowledge> GetAll()
        {
            throw new NotImplementedException();
        }

        public Knowledge GetById(int id)
        {
            throw new NotImplementedException();
        }


    }
}