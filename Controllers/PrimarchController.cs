using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AstartesCodexProject.Data;
using System.Collections.Generic;
using AstartesCodexProject.Models;


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
    public ActionResult<IEnumerable<Primarch>> GetAllPrimarch()
    {
      try
      {
        return Ok(_repository.GetAllPrimarch());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Primarch> Get(int id)
    {
      try
      {
        return Ok(_repository.GetPrimarchById(id));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }



    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult<Primarch> DeletePrimarchById(int id)
    {
      try
      {
        return Ok(_repository.DeletePrimarchById(id));
      }

      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
  }
}
