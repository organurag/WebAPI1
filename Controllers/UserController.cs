
using BLL.UserController;
using DAL;
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
        private readonly IUserControllerBL _IUserControllerBL;

        public UserController(IUserControllerBL iuserControllerBL) 
        {
            _IUserControllerBL = iuserControllerBL;
        }

        //private DBWEBAPIEntities _context;

        //public UserController()
        //{
        //    _context = new DBWEBAPIEntities();
        //}


        [HttpGet]
        public IHttpActionResult Index()
        {

            //var user = _context.tblUsers.ToList();

            List<tblUser> users = _IUserControllerBL.GetAllUsers();

            return Ok(users);
        }


        public IHttpActionResult Create(tblUser user)
        {

            //_context.tblUsers.Add(user);
            //_context.SaveChanges();
            _IUserControllerBL.CreateUser(user);

            return Ok("Created");
        }

        public IHttpActionResult GetUserID(int id)
        {
            //tblUser user =  _context.tblUsers.Find(id);

            tblUser user = _IUserControllerBL.FindUserById(id);

            return Ok(user);
        }

        [HttpPut]
        public IHttpActionResult UpdateUser(int id, tblUser user)
        {
            if(id == user.Id)
            {
                //tblUser _user = _context.tblUsers.Find(user.Id);

                //_user.Name = user.Name;
                //_user.email = user.email;
                //_user.cityId = user.cityId;

                //_context.SaveChanges();

                _IUserControllerBL.UpdateUser(user);

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
            //tblUser _user = _context.tblUsers.Find(id);
            //_context.tblUsers.Remove(_user);
            //_context.SaveChanges();

            _IUserControllerBL.DeleteUser(id);

            return Ok("Deleted");
        }
     
    }
}
