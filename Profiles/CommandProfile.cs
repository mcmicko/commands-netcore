using AutoMapper;
using Commander.Dtos;
using Commander.Model;

namespace Commander.Profiles
{
  public class CommandProfile : Profile
  {
    public CommandProfile()
    {
      CreateMap<Command, CommandReadDto>();
    }
  }
}