using System.Collections.Generic;
using Commander.Data;
using Commander.Model;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CommandsController : ControllerBase
  {
    private readonly MockCommanderRepo _repository = new MockCommanderRepo();

    [HttpGet]
    public ActionResult<IEnumerable<Command>> GetAllCommands()
    {
      var commandItems = _repository.GetAppCommands();

      return Ok(commandItems);
    }

    [HttpGet("{id}")]
    public ActionResult<Command> GetCommandById(int Id)
    {
      var commandItem = _repository.GetCommandById(Id);
      return Ok(commandItem);
    }
  }
}