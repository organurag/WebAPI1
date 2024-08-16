
using BLL.UserController;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebAPI1.Controllers
{
   
    public class UserController : ApiController
    {
        private readonly IUserControllerBL _IUserControllerBL;

        public UserController(IUserControllerBL iuserControllerBL) 
        {
            _IUserControllerBL = iuserControllerBL;
        }

        


        [HttpGet]
        public IHttpActionResult Index()
        {

           

            List<tblUser> users = _IUserControllerBL.GetAllUsers();

            return Ok(users);
        }


        public IHttpActionResult Create(tblUser user)
        {

           
            _IUserControllerBL.CreateUser(user);

            return Ok("Created");
        }

        public IHttpActionResult GetUserID(int id)
        {
           

            tblUser user = _IUserControllerBL.FindUserById(id);

            return Ok(user);
        }

        [HttpPut]
        public IHttpActionResult UpdateUser(int id, tblUser user)
        {
            if(id == user.Id)
            {
                

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
           
            _IUserControllerBL.DeleteUser(id);

            return Ok("Deleted");
        }
     
    }
}
