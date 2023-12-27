using AutoMapper;
using Blog.Entity.DTOs.Categories;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.AutoMapper.Users
{
    public class UserProfile :Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, AppUser>().ReverseMap();

            CreateMap<UserAddDto, AppUser>().ReverseMap();

            CreateMap<UserUpdateDto, AppUser>().ReverseMap();

            CreateMap<UserProfileDto, AppUser>().ReverseMap();
        }
    }
}
