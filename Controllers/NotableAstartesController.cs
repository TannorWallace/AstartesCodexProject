using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AstartesCodexProject.Models;
using AstartesCodexProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace AstartesCodexProject.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NotableAstartesController : ControllerBase
  {
    private readonly NotableAstartesRepository _repository;
    public NotableAstartesController(NotableAstartesRepository repository)
    {
      _repository = repository;
    }

    // POST api/values
    [HttpPost]
    public ActionResult<NotableAstartes> Post([FromBody] NotableAstartes notableAstartes)
    {
      try
      {
        return Ok(_repository.CreateNotableAstartes(notableAstartes));
      }
      catch (System.Exception)
      {

        throw;
      }
    }


    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
    }



    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
