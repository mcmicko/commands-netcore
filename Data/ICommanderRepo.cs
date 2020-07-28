using System.Collections.Generic;
using Commander.Model;

namespace Commander.Data
{
  public interface ICommanderRepo
  {
    IEnumerable<Command> GetAppCommands();
    Command GetCommandById(int id);
  }
}