using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Model;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CommandsController : ControllerBase
  {
    private readonly ICommanderRepo _repository;
    private readonly IMapper _mapper;

    public CommandsController(ICommanderRepo repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    // private readonly MockCommanderRepo _repository = new MockCommanderRepo();

    [HttpGet]
    public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
    {
      var commandItems = _repository.GetAllCommands();

      return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
    }

    [HttpGet("{id}")]
    public ActionResult<CommandReadDto> GetCommandById(int Id)
    {
      var commandItem = _repository.GetCommandById(Id);
      if (commandItem != null)
        return Ok(_mapper.Map<CommandReadDto>(commandItem));
      return NotFound();
    }
  }
}