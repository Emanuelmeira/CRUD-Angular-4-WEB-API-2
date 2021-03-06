﻿using Easy.Domain.Entities;
using Easy.Infra.Exceptions;
using Easy.Infra.Interfaces;
using Easy.Infra.Repository;
using System.Collections.Generic;
using Easy.Api.Interfaces.Services;

namespace Easy.Api.Services
{
    public class DeveloperService : IService<Developer>
    {        
        private IDeveloperRepository DeveloperRepository;
        private IBankInformationRepository BankInformationRepository;
        private IKnowledgeRepository KnowledgeRepository;

        public DeveloperService()
        {
            BankInformationRepository = new BankInformationRepository();
            KnowledgeRepository = new KnowledgeRepository();
            DeveloperRepository = new DeveloperRepository();
        }

        //GET all Developers
        public List<Developer> GetAll()
        {
            try
            {             
                 return DeveloperRepository.GetAll();
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }
        
        //ADD Developer
        public void Save(Developer Developer)
        {
            try
            {                
                DeveloperRepository.Save(Developer);             
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //UPDATE Developer
        public void Update(Developer Developer)
        {
            try
            {
                BankInformationRepository.Update(Developer.BankInf);
                KnowledgeRepository.Update(Developer.Knowledge);
                DeveloperRepository.Update(Developer);                
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //GET Developer
        public Developer GetById(int id)
        {
            try
            {
                return DeveloperRepository.GetById(id);               
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //DELETE Developer
        public Developer Delete(int id)
        {
            try
            {
                return DeveloperRepository.Delete(id);                   
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }


    }
}