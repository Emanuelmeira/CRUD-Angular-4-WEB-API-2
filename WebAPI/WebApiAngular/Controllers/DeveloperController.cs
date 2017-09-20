using Domain.Entities;
using Domain.Exceptions;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebApiAngular.Controllers
{    
    public class DeveloperController : ApiController
    {
        public DeveloperService DeveloperService;
        public DeveloperController()
        {
            DeveloperService = new DeveloperService();
        }

        // GET: api/Developers
        [ResponseType(typeof(Developer[]))]
        public IHttpActionResult GetDeveloper()
        {
            try
            {
                return Ok(DeveloperService.getDevelopers());
            }
            catch (RepositoryException ex)
            {
                return InternalServerError(ex);                
            }           
        }

        // POST: api/Developer
        [ResponseType(typeof(Developer))]     
        public IHttpActionResult PostDeveloper(Developer Developer)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                DeveloperService.PostDeveloper(Developer);

                return CreatedAtRoute("DefaultApi", new { id = Developer.Id }, Developer);                
            }
            catch (RepositoryException ex)
            {
                return InternalServerError(ex);                
            }
        }

        // PUT: api/Developer/5
        [ResponseType(typeof(Developer))]
        public IHttpActionResult PutDeveloper(Developer Developer)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                        
                DeveloperService.UpdateDeveloper(Developer);

                return Ok(Developer);               
            }
            catch (RepositoryException ex)
            {
                return InternalServerError(ex);
            }
        }
        

        // GET: api/Developer/:id
        [ResponseType(typeof(Developer))]
        public IHttpActionResult GetDeveloper(int id)
        {
            try
            {
                Developer Developer = DeveloperService.GetDeveloper(id);

                if (Developer == null)
                {
                    return NotFound();
                }

                return Ok(Developer);              
            }
            catch (RepositoryException ex)
            {
                return InternalServerError(ex);
            }
        }

        [ResponseType(typeof(Developer))]
        public IHttpActionResult DeleteDeveloper(int id)
        {
            try
            {
                Developer Developer = DeveloperService.DeleteDeveloper(id);

                if (Developer == null)
                {
                    return NotFound();
                }

                return Ok(Developer);
            }
            catch (RepositoryException ex)
            {
                return InternalServerError(ex);
            }           
        }
    }
}
