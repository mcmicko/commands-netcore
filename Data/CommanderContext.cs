using Commander.Model;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
  public class CommanderContext : DbContext
  {
    public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt) { }

    public virtual DbSet<Command> Commands { get; set; }
  }
}