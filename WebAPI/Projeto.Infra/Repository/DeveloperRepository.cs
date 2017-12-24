using Easy.Domain.Entities;
using Easy.Infra.Context;
using Projeto.Infra.Exceptions;
using Projeto.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Projeto.Infra.Repository
{
    public class DeveloperRepository : IDeveloperRepository
    {                
        private EFContext Context;

        public DeveloperRepository()
        {
            Context = EFContext.ContextFactory();
        }

        //GET ALL Developers
        public List<Developer> GetAll()
        {
            try
            {
               IQueryable<Developer> query = Context.Developers;

               var item =  query.Include(b => b.BankInf)
                                .Include(k => k.Knowledge)
                                .ToList();               

               return item;

            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }

        //SAVE Developer
        public void Save(Developer Developer)
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

        //UPDATE Developer
        public void Update(Developer Developer)
        {

            try
            {                
                
                Context.Developers.Attach(Developer);
                Context.Entry(Developer).State = EntityState.Modified;                
                Context.SaveChanges(); 
                
                //var original = GetById(Developer.Id);
                //Context.Entry(original).CurrentValues.SetValues(Developer);
                //Context.SaveChanges();


                //Context.Entry(Developer).State = EntityState.Modified;                
                //Context.SaveChanges(); 

            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
            
        }

        //GET Developer
        public Developer GetById(int id)
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
        public Developer Delete(int id)
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

                IQueryable<Developer> query = Context.Developers;

                var Developer = query.Where(x => x.Id == id)
                                     .Include(b => b.BankInf)
                                     .Include(k => k.Knowledge)
                                     .FirstOrDefault();
                return Developer;
            }
            catch (Exception ex)
            {
                throw new RepositoryException(ex.Message, ex);
            }
        }



    }
}