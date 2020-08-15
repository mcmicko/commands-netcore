using System.Collections.Generic;
using Commander.Model;

namespace Commander.Data
{
  public interface ICommanderRepo
  {
    IEnumerable<Command> GetAllCommands();
    Command GetCommandById(int id);
  }
}