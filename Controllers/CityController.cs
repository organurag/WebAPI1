using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI1.Models;

namespace WebAPI1.Controllers
{
    public class CityController : ApiController
    {
        private DBWEBAPIEntities _dbcontex;
        public CityController() 
        {
            _dbcontex = new DBWEBAPIEntities();
        }
        
        
        [HttpGet]
        public IHttpActionResult GetCityByState(int id)
        {
           List<City> cities;
            cities = _dbcontex.Cities.Where(c => c.StateId == id).ToList();

            return Ok(cities);
        }

        public IHttpActionResult GetAllCities()
        {
            List<City> cities;
            cities = _dbcontex.Cities.ToList();

            return Ok(cities);
        }
    }
}
