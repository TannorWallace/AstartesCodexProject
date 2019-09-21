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
  public class LegionController : ControllerBase
  {
    private readonly LegionRepository _repository;
    public LegionController(LegionRepository repository)
    {
      _repository = repository;
    }

    // POST api/values
    [HttpPost]
    public ActionResult<Legion> Post([FromBody] Legion legion)
    {
      try
      {
        return Ok(_repository.CreateLegion(legion));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<Legion>> GetAllLegion()
    {
      try
      {
        return Ok(_repository.GetAllLegion());
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }

    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Legion> GetLegionById(int id)
    {
      try
      {
        return Ok(_repository.GetLegionById(id));

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
    public ActionResult<Legion> DeleteLegionById(int id)
    {
      try
      {
        return Ok(_repository.DeleteLegionById(id));
      }

      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
  }
}
