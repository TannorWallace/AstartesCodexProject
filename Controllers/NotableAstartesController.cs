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
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }


    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<NotableAstartes>> GetAllNotableAstartes()
    {
      try
      {
        return Ok(_repository.GetAllNotableAstartes());

      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }

    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<NotableAstartes> GetNotableAstartesById(int id)
    {
      try
      {
        return Ok(_repository.GetNotableAstartesById(id));
      }
      catch (System.Exception)
      {

        throw;
      }
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult<NotableAstartes> DeleteNotableAstartesById(int id)
    {
      try
      {
        return Ok(_repository.DeleteNotableAstartesById(id));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
  }
}
