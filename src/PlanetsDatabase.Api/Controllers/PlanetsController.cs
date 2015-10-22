using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using PlanetDatabase.Api.Models;

namespace PlanetsDatabase.Api.Controllers
{
    public class PlanetsController : ApiController
    {
        private readonly List<Planet> _planets;

        public PlanetsController()
        {
            _planets = new List<Planet>
            {
            new Planet{Id = 1, Name = "Mercury", DistanceFromSun = 120},
            new Planet{Id = 2, Name = "Venus", DistanceFromSun = 340},
            new Planet{Id = 3, Name = "Earth", DistanceFromSun = 640},
        };
        }

        public PlanetsController(List<Planet> planets)
        {
            _planets = planets;
        }

        // GET api/planets
        [EnableCors(origins: "http://localhost:59784", headers: "*", methods: "*")]
        public IEnumerable<Planet> Get()
        {
            return _planets;
        }

        // GET api/planets/2
        public IHttpActionResult Get(int id)
        {
            var planet = _planets.FirstOrDefault(p => p.Id == id);
            if (planet == null)
            {
                return NotFound();
            }
            return Ok(planet);
        }
    }
}