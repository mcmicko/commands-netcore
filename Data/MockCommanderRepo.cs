using System.Collections.Generic;
using Commander.Model;

namespace Commander.Data
{
  public class MockCommanderRepo : ICommandRepo
  {
    public IEnumerable<Command> GetAppCommands()
    {
      var commands = new List<Command>
      {
        new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" },
        new Command { Id = 1, HowTo = "Boil an egg2", Line = "Boil water2", Platform = "Kettle & Pan2" },
        new Command { Id = 2, HowTo = "Boil an egg3", Line = "Boil water3s", Platform = "Kettle & Pan3" }
      };
      return commands;
    }

    public Command GetCommandById(int id)
    {
      return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan" };
    }
  }
}