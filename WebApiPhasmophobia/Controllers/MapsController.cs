using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPhasmophobia.Models;
using WebApiPhasmophobia.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiPhasmophobia.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapsController : ControllerBase
    {
        RepositoryMaps repo;

        // GET: api/<EquipmentsController>
        [HttpGet]
        public ActionResult<List<Map_ES>> Get()
        {
            return this.repo.GetAllMapsES();
        }

        // GET api/<EquipmentsController>/5
        [HttpGet]
        public ActionResult<Map_ES> Get(int id)
        {
            return this.repo.GetMapES(id);
        }
        //// GET: api/<MapsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<MapsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<MapsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<MapsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MapsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
