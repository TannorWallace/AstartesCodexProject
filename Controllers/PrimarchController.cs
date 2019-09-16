using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AstartesCodexProject.Models;
using AstartesCodexProject.Data;

namespace AstartesCodexProject.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PrimarchController : ControllerBase
  {

    private readonly PrimarchRepository _repository;
    public PrimarchController(PrimarchRepository repository)
    {
      _repository = repository;
    }

    // POST api/values
    [HttpPost]
    public ActionResult<Primarch> Post([FromBody] Primarch primarch)
    {
      try
      {
        return Ok(_repository.CreatePrimarch(primarch));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
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
