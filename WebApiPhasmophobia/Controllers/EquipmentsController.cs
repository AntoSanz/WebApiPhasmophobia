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
    public class EquipmentsController : ControllerBase
    {
        RepositoryEquipments repo;

        // GET: api/<EquipmentsController>
        [HttpGet]
        public ActionResult<List<Equipment_ES>> Get()
        {
            return this.repo.GetAllEquipmentsES();
        }

        // GET api/<EquipmentsController>/5
        [HttpGet]
        public ActionResult<Equipment_ES> Get(int id)
        {
            return this.repo.GetEquipmentES(id);
        }

        //// GET: api/<EquipmentsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<EquipmentsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<EquipmentsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<EquipmentsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<EquipmentsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}


    }
}
