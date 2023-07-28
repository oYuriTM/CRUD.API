using AutoMapper;
using CRUD.Domain.Dto.Users;
using CRUD.Domain.Models;
using System;

namespace CRUD.Service.Configuration
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Users, UserRegisterDto>().ReverseMap();
            CreateMap<Users, UserResponseDto>().ReverseMap();
            CreateMap<Users, UserUpdateDto>().ReverseMap();
        }
    }
}
