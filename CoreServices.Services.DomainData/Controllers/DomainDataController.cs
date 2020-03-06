using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreServices.Services.DomainData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomainDataController : ControllerBase
    {
        public readonly IMediator mediator; 

        public DomainDataController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET: api/DomainData
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET: api/DomainData/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DomainData
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/DomainData/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
