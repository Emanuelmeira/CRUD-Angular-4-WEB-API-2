using Domain.Entities;
using Domain.Exceptions;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiAngular.Interfaces.Services;

namespace WebApiAngular.Services
{
    public class DeveloperService : IService<Developer>
    {
        private DeveloperRepository DeveloperRepository;

        public DeveloperService()
        {
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