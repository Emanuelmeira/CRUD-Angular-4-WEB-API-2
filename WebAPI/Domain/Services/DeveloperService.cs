using Domain.Entities;
using Domain.Exceptions;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Services
{
    public class DeveloperService
    {
        private DeveloperRepository DeveloperRepository;

        public DeveloperService()
        {
            DeveloperRepository = new DeveloperRepository();
        }

        //GET all Developers
        public IQueryable<Developer> getDevelopers()
        {
            try
            {             
                 return DeveloperRepository.GetDevelopers();
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }
        
        //ADD Developer
        public void PostDeveloper(Developer Developer)
        {
            try
            {                
                DeveloperRepository.PostDeveloper(Developer);             
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //UPDATE Developer
        public void UpdateDeveloper(Developer Developer)
        {
            try
            {
                DeveloperRepository.UpdateDeveloper(Developer);                
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //GET Developer
        public Developer GetDeveloper(int id)
        {
            try
            {
                return DeveloperRepository.GetDeveloper(id);               
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //DELETE Developer
        public Developer DeleteDeveloper(int id)
        {
            try
            {
                return DeveloperRepository.DeleteDeveloper(id);                   
            }
            catch (RepositoryException ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }


    }
}