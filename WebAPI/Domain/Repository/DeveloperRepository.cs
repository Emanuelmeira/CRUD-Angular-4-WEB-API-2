using Domain.Context;
using Domain.Entities;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Domain.Repository
{
    public class DeveloperRepository
    {                
        private EFContext Context;

        public DeveloperRepository()
        {
            Context = EFContext.ContextFactory();
        }

        //Get all Developers
        public IQueryable<Developer> GetDevelopers()
        {
            try
            {
                return Context.Developers;
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //Post Developer
        public void PostDeveloper(Developer Developer)
        {
            try
            {
                Context.Developers.Add(Developer);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }  
        }

        //Put Developer
        public void UpdateDeveloper(Developer Developer)
        {

            try
            {
                Context.Entry(Developer).State = EntityState.Modified;
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
            
        }

        //GET Developer
        public Developer GetDeveloper(int id)
        {
            try
            {
                Developer Developer = GetDeveloperById(id);
                return Developer;
                
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //DELETE Developer
        public Developer DeleteDeveloper(int id)
        {
            try
            {
                Developer Developer = GetDeveloperById(id);

                if (Developer != null)
                {               
                    Context.Developers.Remove(Developer);
                    Context.SaveChanges();
                }
            
                return Developer;

            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }


        private Developer GetDeveloperById(int id)
        {
            try
            {
                Developer Developer = Context.Developers.Find(id);
                return Developer;
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }


    
    }
}