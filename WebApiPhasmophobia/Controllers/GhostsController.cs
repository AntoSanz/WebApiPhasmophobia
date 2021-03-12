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
    public class GhostsController : ControllerBase
    {
        RepositoryGhosts repo;

        // GET: api/<EquipmentsController>
        [HttpGet]
        public ActionResult<List<Ghost_ES>> Get()
        {
            return this.repo.GetAllGhostsES();
        }

        // GET api/<EquipmentsController>/5
        [HttpGet]
        public ActionResult<Ghost_ES> Get(int id)
        {
            return this.repo.GetGhostES(id);
        }

        //// GET: api/<GhostsController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<GhostsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<GhostsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<GhostsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<GhostsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
