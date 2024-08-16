using BLL.StateController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebAPI1.Controllers
{
    public class StateController : ApiController
    {
       

        private readonly IStateControlleBL _stateControllerBL;
        public StateController(IStateControlleBL stateControlleBL)
        {
            _stateControllerBL = stateControlleBL;
        }

        public IHttpActionResult GetStates()
        {
            
           
           var states = _stateControllerBL.GetAllStates();
            return Ok(states);
        }
    }
}
