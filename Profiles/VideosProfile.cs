using AutoMapper;
using workspace.Context.DTO;
using workspace.Models;

namespace workspace.Profiles
{
  public class VideosProfile : Profile
  {
    public VideosProfile()
    {
      CreateMap<CreateVideoDTO, Videos>();
      CreateMap<Videos, CreateVideoDTO>();
    }
  }
}