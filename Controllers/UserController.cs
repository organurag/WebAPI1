using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI1.Models;

namespace WebAPI1.Controllers
{
   
    public class UserController : ApiController
    {
        private DBWEBAPIEntities _context;

        public UserController()
        {
            _context = new DBWEBAPIEntities();
        }


        [HttpGet]
        public IHttpActionResult Index()
        {
           
            var user = _context.tblUsers.ToList();

            return Ok(user);
        }


        public IHttpActionResult Create(tblUser user)
        {
 
            _context.tblUsers.Add(user);
            _context.SaveChanges();

            return Ok("Created");
        }

        public IHttpActionResult GetUserID(int id)
        {
          tblUser user =  _context.tblUsers.Find(id);

            return Ok(user);
        }

        [HttpPut]
        public IHttpActionResult UpdateUser(int id, tblUser user)
        {
            if(id == user.Id)
            {
                tblUser _user = _context.tblUsers.Find(user.Id);

                _user.Name = user.Name;
                _user.email = user.email;

                _context.SaveChanges();

                return Ok("Updated");

            }
            else
            {
                return BadRequest();
            }
            
        }
        [Route("del")]
        [HttpDelete]
        public IHttpActionResult DeleteUser(int id)
        {
            tblUser _user = _context.tblUsers.Find(id);
            _context.tblUsers.Remove(_user);
            _context.SaveChanges();

            return Ok("Deleted");
        }
     
    }
}
