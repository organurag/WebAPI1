using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI1.Models;

namespace WebAPI1.Controllers
{
    public class StateController : ApiController
    {
        private readonly DBWEBAPIEntities _dbcontex;
        public StateController()
        {
            _dbcontex = new DBWEBAPIEntities();
        }

        public IHttpActionResult GetStates()
        {
            List<State> states;
            states = _dbcontex.States.ToList();
            return Ok(states);
        }
    }
}
