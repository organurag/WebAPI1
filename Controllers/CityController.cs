using BLL.CityController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebAPI1.Controllers
{
    public class CityController : ApiController
    {
        private readonly ICityControllerBL _cityControllerBL;

        
        public CityController(ICityControllerBL cityControllerBL) 
        {
            
            _cityControllerBL = cityControllerBL;
        }
        
        
        [HttpGet]
        public IHttpActionResult GetCityByState(int id)
        {
           

             var cities = _cityControllerBL.GetCityByState(id);

            return Ok(cities);
        }

        public IHttpActionResult GetAllCities()
        {
            

            var cities = _cityControllerBL.GetAllCities();

            return Ok(cities);
        }
    }
}
